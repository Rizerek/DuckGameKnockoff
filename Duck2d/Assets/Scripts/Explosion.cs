﻿using System.Collections;

using UnityEngine;

public class Explosionn : MonoBehaviour
{

    
    public float speed;
    public Rigidbody2D rb;
    
    public GameObject prefabExpl;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine( Explode());
        rb.velocity = transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator Explode()
    {
        yield return new WaitForSeconds(1f);
        Instantiate(prefabExpl, transform.position, Quaternion.identity);
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
