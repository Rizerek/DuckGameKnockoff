using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun2Red : MonoBehaviour
{
    public int startbullets;
    private int bullets;
    public float fireRate;
    public Transform istol;
    public Transform shotPoint;
    public GameObject bulletPrefab;
    float timeToFire;
    // Start is called before the first frame update
    void Start()
    {
        bullets = startbullets;
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
        else if (Input.GetKey("e") && Time.time > timeToFire)
        {
            timeToFire = Time.time + 1 / fireRate;
            Shoot();
        }

        if(bullets <=0)
        {
            gameObject.SetActive(false);
            bullets = startbullets;
        }

    }
    void Shoot()
    {
        Instantiate(bulletPrefab, shotPoint.position, istol.rotation);
        bullets -= 1;
    }
}
