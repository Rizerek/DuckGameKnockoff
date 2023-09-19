using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockBall : MonoBehaviour
{
    

    public float speed;
    public Rigidbody2D rb;

    
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
        yield return new WaitForSeconds(6f);
        
        Destroy(gameObject);

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Walls")
        {
            StartCoroutine(Explode());
        }
        
    }

    }
