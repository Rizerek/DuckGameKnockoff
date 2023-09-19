using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pickup : MonoBehaviour
{
 

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.layer == 8)
        {
           
            gameObject.SetActive(false);
        }

    }
}
