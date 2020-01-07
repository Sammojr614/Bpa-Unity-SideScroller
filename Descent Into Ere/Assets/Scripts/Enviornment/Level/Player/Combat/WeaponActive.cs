using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponActive : MonoBehaviour {

    //Knife used by the player
    public GameObject ButterKnifeRight;
    public GameObject ButterKnifeLeft;
    //SteakKnife used by the player
    public GameObject SteakKnifeRight;
    public GameObject SteakKnifeLeft;
    //Checks if knife is drawn
    public static bool KnifeDrawn;

    //On Start, the knife is equipped
	void Start () {
        if(LoadData.PlayerHaveKnifeUpgrade == true)
        {
            ButterKnifeRight.SetActive(false);
            ButterKnifeLeft.SetActive(false);
            SteakKnifeRight.SetActive(true);
            SteakKnifeLeft.SetActive(true);
        }
        else
        {
            ButterKnifeRight.SetActive(true);
            ButterKnifeLeft.SetActive(true);
            SteakKnifeRight.SetActive(false);
            SteakKnifeLeft.SetActive(false);
        }
        
        KnifeDrawn = true;
    }
	
	/* If the player presses F, 
     * and the knife is drawn,
     * the player will put away the knife,
     * On the contrary, if the player presses F,
     * and the knife is away,
     * the player will draw the knife
     */
	void Update () {
        if (Input.GetKeyDown(KeyCode.F) && KnifeDrawn == true)
        {
            if(Flipper.facingLeft == true)
            {
                ButterKnifeLeft.SetActive(false);
                SteakKnifeLeft.SetActive(false);
            }
            else
            {
                ButterKnifeRight.SetActive(false);
                SteakKnifeRight.SetActive(false);
            }
            KnifeDrawn = false;
        }
        else if(Input.GetKeyDown(KeyCode.F) && KnifeDrawn == false)
        {
            if(LoadData.PlayerHaveKnifeUpgrade == false)
            {
                if(Flipper.facingLeft == true)
                {
                    ButterKnifeLeft.SetActive(true);
                }
                else
                {
                    ButterKnifeRight.SetActive(true);
                }
            }
            else if(LoadData.PlayerHaveKnifeUpgrade == true)
            {
                if(Flipper.facingLeft == true)
                {
                    SteakKnifeLeft.SetActive(true);
                }
                else
                {
                    SteakKnifeRight.SetActive(true);
                }
            }
            KnifeDrawn = true;
        }
	}
}
