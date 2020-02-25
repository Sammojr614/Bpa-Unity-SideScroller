using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stamina : MonoBehaviour
{
                                            /* This Whole Script is for Displaying the Amount of Stamina Left */
    const int totalStamina = 10;
    public SpriteRenderer[] StaminaCharges;
    private void Update()
    {
        //For when Stamina is Full
        if (Sprint.stamina >= 10)
        {
            foreach (SpriteRenderer charges in StaminaCharges)
            {
                charges.enabled = true;
            }
        }
        //For When Stamina is Empty
        if (Sprint.stamina <= 0)
        {
            foreach (SpriteRenderer charges in StaminaCharges)
            {
                charges.enabled = false;
            }
        }
                                                /* The Specific Number Display Manager */
        // 9
        if(Sprint.stamina <= 9)
        {
            StaminaCharges[0].enabled = false;
        }else if(Sprint.stamina >= 9)
        {
            StaminaCharges[0].enabled = true;
        }
        // 7.5
        if(Sprint.stamina <= 8.5)
        {
            
            StaminaCharges[1].enabled = false;
        }else if(Sprint.stamina >= 8.5)
        {
           
            StaminaCharges[1].enabled = true;
        }
        //4.5
        if(Sprint.stamina <= 7.5)
        {
            StaminaCharges[2].enabled = false;
        }else if(Sprint.stamina >= 7.5)
        {
            StaminaCharges[2].enabled = true;
        }
        // 3
        if(Sprint.stamina <= 6)
        {
            StaminaCharges[3].enabled = false;
        }else if(Sprint.stamina >= 6)
        {
            StaminaCharges[3].enabled = true;
        }
        //2.5
        if(Sprint.stamina <= 4.5)
        {
            StaminaCharges[4].enabled = false;
        }else if(Sprint.stamina >= 4.5)
        {
            StaminaCharges[4].enabled = true;
        }
        // 1
        if(Sprint.stamina <= 1)
        {
            StaminaCharges[5].enabled = false;
        }else if(Sprint.stamina >= 1)
        {
            StaminaCharges[5].enabled = true;
        }
    }
}
