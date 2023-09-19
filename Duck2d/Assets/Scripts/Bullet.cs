using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour
{


    public Transform rotation;
    public int dmg;
    public float speed;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {

        rb.velocity = transform.right * speed;






    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        RedControll Red = col.GetComponent<RedControll>();
        BlueControll Blue = col.GetComponent<BlueControll>();
        if (col.gameObject.name == "Bullet(Clone)")
        {

        }
        else
        {
            Destroy(gameObject);
        }

        if (Blue != null)
        {
            Blue.TakeDamage(dmg);
        }
        if (Red != null)
        {
            Red.TakeDamage(dmg);
        }



    }
}


