using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackBlue : MonoBehaviour
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
        Event x = Event.current;


        if (x.control)
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
}
