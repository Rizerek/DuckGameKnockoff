using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackExp : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;

    public GameObject prefabExpl;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Explode());
        rb.velocity = transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public IEnumerator Explode()
    {
        yield return new WaitForSeconds(1.5f);
        Instantiate(prefabExpl, transform.position, Quaternion.identity);
        Destroy(gameObject);

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        StartCoroutine(Explode());
    }
}
