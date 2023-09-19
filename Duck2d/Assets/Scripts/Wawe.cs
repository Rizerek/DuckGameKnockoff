using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wawe : MonoBehaviour
{
    public int dmg;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Exp());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        RedControll Red = col.GetComponent<RedControll>();
        BlueControll Blue = col.GetComponent<BlueControll>();
  
        

        if (Blue != null)
        {
            Blue.TakeDamage(dmg);
        }
        if (Red != null)
        {
            Red.TakeDamage(dmg);
        }



    }
    public IEnumerator Exp()
    {

        yield return new WaitForSeconds(0.1f);
        Destroy(gameObject);
    }
}
