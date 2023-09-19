using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackRed : MonoBehaviour
{
    public Transform istol;
    public Transform shotPoint;
    public GameObject GranPrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {



        if (Input.GetKey("e"))
        {
            StartCoroutine(Throw());
            gameObject.SetActive(false);
        }
    }
    public IEnumerator Throw()
    {
        Instantiate(GranPrefab, shotPoint.position, istol.rotation);
        yield return new WaitForSeconds(1f);
    }
    void OnCollisionEnter2d(Collision col)
    {


    }
}
