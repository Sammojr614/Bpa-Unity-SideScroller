using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponActive : MonoBehaviour {

    //Knife used by the player
    public GameObject ButterKnife;
    //Checks if knife is drawn
    public bool KnifeDrawn;

    //On Start, the knife is equipped
	void Start () {
        ButterKnife.SetActive(true);
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
            KnifeDrawn = false;
        }
        else if(Input.GetKeyDown(KeyCode.F) && KnifeDrawn == false)
        {
            ButterKnife.SetActive(true);
            KnifeDrawn = true;
        }
	}
}
