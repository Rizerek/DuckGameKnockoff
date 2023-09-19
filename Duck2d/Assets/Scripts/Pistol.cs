using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : MonoBehaviour
{
    public float fireRate;
    public  Transform istol;
    public Transform shotPoint;
    public GameObject bulletPrefab;
    float timeToFire;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fireRate == 0)
        {
            if (Input.GetKey("e"))
            {
                Shoot();
            }
        }
        else if (Input.GetKey("e")&&Time.time> timeToFire)
        {
            timeToFire = Time.time + 1 / fireRate;
            Shoot();
        }
       
    }
    void Shoot()
    {
        Instantiate(bulletPrefab, shotPoint.position, istol.rotation);
    }
}
