using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponActive : MonoBehaviour {

    //Knife used by the player
    public GameObject ButterKnife;
    //SteakKnife used by the player
    public GameObject SteakKnife;
    //Checks if knife is drawn
    public static bool KnifeDrawn;

    //On Start, the knife is equipped
	void Start () {
        if(LoadData.PlayerHaveKnifeUpgrade == true){
        ButterKnife.SetActive(false);
        SteakKnife.SetActive(true);
        }else{
            ButterKnife.SetActive(true);
            SteakKnife.SetActive(false);
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
            ButterKnife.SetActive(false);
            SteakKnife.SetActive(false);
            KnifeDrawn = false;
        }
        else if(Input.GetKeyDown(KeyCode.F) && KnifeDrawn == false)
        {
            if(LoadData.PlayerHaveKnifeUpgrade == false){
            SteakKnife.SetActive(false);
            ButterKnife.SetActive(true);
            }else if(LoadData.PlayerHaveKnifeUpgrade == true){
                SteakKnife.SetActive(true);
                ButterKnife.SetActive(false);
            }
            KnifeDrawn = true;
        }
	}
}
