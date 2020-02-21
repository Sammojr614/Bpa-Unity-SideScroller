using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stamina : MonoBehaviour
{
    const int totalStamina = 10;
    public GameObject[] StaminaCharges;
    private void Update()
    {
        if(Sprint.stamina == 10)
        {
            foreach(GameObject charge in StaminaCharges)
            {
                charge.SetActive(true);
            }
        }
        
        //First Charge Gone
        if (Sprint.stamina <= 8.5) 
        {
            StaminaCharges[0].SetActive(false);
        }else if(Sprint.stamina <= 7)
        {
            //Second Charge Gone
            StaminaCharges[1].SetActive(false);
        }else if(Sprint.stamina <= 6.5)
        { //Third Charge Gone
            StaminaCharges[2].SetActive(false);
        }else if(Sprint.stamina <= 3)
        {
            //Forth Charge Gone
            StaminaCharges[3].SetActive(false);
        }else if(Sprint.stamina <= 2.5)
        {
            //Fifth Charge Gone
            StaminaCharges[4].SetActive(false);
        }else if(Sprint.stamina <= 1)
        {
            //Last Charge Gone
            StaminaCharges[5].SetActive(false);
        }
        if (Sprint.stamina <= 0)
        {
            foreach (GameObject charge in StaminaCharges)
            {
                charge.SetActive(false);
            }
        }
    }
}
