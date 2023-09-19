using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol2 : MonoBehaviour
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
        
    }
    void Shoot()
    {
        Instantiate(bulletPrefab, shotPoint.position, istol.rotation);
    }
    void OnGUI()
    {
       Event x = Event.current;

        if (fireRate == 0)
        {
            if (x.control)
            {
                Shoot();
            }
        }
        else if (x.control && Time.time > timeToFire)
        {
            timeToFire = Time.time + 1 / fireRate;
            Shoot();
        }
    }
}
