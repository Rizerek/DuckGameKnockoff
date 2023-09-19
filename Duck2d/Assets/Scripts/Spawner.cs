using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    public GameObject Rock;
    public GameObject Knock;
    public GameObject BLACK;
    // Start is called before the first frame update
    public GameObject Gun2Pickup;
    public GameObject Gun2Copy;
    public GameObject Pistol;
    public GameObject Pistol2;
    public GameObject GranadePick;
    public GameObject GranadePick2;
    void Start()
    {
        StartCoroutine(Spawn());
    }
        void Update()
    {
        
    }
    public IEnumerator Spawn()
    {
        
        yield return new WaitForSeconds(10f);
       
        Gun2Pickup.SetActive(true);
        Gun2Copy.SetActive(true);
        Pistol.SetActive(true);
        Pistol2.SetActive(true);
        GranadePick2.SetActive(true);
        GranadePick.SetActive(true);
        BLACK.SetActive(true);
        Knock.SetActive(true);
        Rock.SetActive(true);
        StartCoroutine(Spawn2());

    }
    public IEnumerator Spawn2()
    {

        yield return new WaitForSeconds(10f);
        
        Gun2Pickup.SetActive(true);
        Gun2Copy.SetActive(true);
        Pistol.SetActive(true);
        Pistol2.SetActive(true);
        GranadePick2.SetActive(true);
        GranadePick.SetActive(true);
        BLACK.SetActive(true);
        Knock.SetActive(true);
        Rock.SetActive(true);
        StartCoroutine(Spawn());

    }
    // Update is called once per frame

}
