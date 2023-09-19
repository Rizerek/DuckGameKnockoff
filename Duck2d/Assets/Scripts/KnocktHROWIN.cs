using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnocktHROWIN : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;

    public GameObject prefabExpl;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        Instantiate(prefabExpl, transform.position, Quaternion.identity);
        
        Destroy(gameObject);
        
    }
}
