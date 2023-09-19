using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Rock;
    public GameObject Rockr;
    public GameObject Rockb;
    public GameObject Game;
    public GameObject Knock;
    public GameObject Knockr;
    public GameObject Knockb;
    public GameObject BLACK;
    public GameObject BLACKb;
    public GameObject BLACKr;
    public GameObject Red;
    public GameObject Blue;
    public GameObject PistolRed;
    public GameObject Gun2Blue;
    public GameObject Gun2Red;
    public GameObject PistolBlue;
    public GameObject Gun2Pickup; 
    public GameObject Gun2Copy; 
    public GameObject Pistol; 
    public GameObject Pistol2;
    public GameObject GranadeBlue;
    public GameObject GranadeRed;
    public GameObject GranadePick;
    public GameObject GranadePick2;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
 
        if (Input.GetKey("f"))
        {
            Red.SetActive(true);
            Blue.SetActive(true);
            PistolRed.SetActive(false);
            Gun2Blue.SetActive(false);
            Gun2Red.SetActive(false);
            PistolBlue.SetActive(false);
            Gun2Pickup.SetActive(true);
            Gun2Copy.SetActive(true);
            Pistol.SetActive(true);
            Pistol2.SetActive(true);
            GranadeBlue.SetActive(false);
            GranadeRed.SetActive(false);
            GranadePick2.SetActive(true);
            GranadePick.SetActive(true);
            BLACK.SetActive(true);
            BLACKb.SetActive(false);
            BLACKr.SetActive(false);
            Knock.SetActive(true);
            Knockr.SetActive(false);
            Knockb.SetActive(false);
            Game.SetActive(false);
            Rockb.SetActive(false);
            Rockr.SetActive(false);
            Rock.SetActive(true);
        }
    }
}
