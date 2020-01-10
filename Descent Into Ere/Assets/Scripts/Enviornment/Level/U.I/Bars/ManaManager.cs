using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaManager : MonoBehaviour {

    //Charges of mana the player can use
    public GameObject Charge1;
    public GameObject Charge2;
    public GameObject Charge3;
    public GameObject Charge4;

    //Amount of charges used
    public static int chargesUsed;

    /* Amount of mana regenered when the player is not using mana
     * and the mana bar is not full
     */
    private float regenTime = 0.5f;

    //Total amount of mana the player can use
    private float totalMana = 10f;

    //On start, totalMana = 10f
    void Start()
    {
        totalMana = 10f;
    }

    void Update()
    {
        /* When the player attacks with the magic ball,
         * they will lose a quarter of the totalMana
         */
        if (Input.GetButtonDown("ManaAttack"))
        {
            if(totalMana != 0f && MagicAttack.canAttack == true)
            {
                totalMana -= 2.5f;
            }
        }
        else
        {
            /* If the player has less than 10 total mana,
             * and is not attacking, they will begin to regenerate mana,
             * and once they reach max stamina, it will stop regenerating
             */            
            if (totalMana < 10f)
            {
                totalMana += regenTime * Time.deltaTime * 5;
            }
            else
            {
                totalMana = 10f;
            }
        }

        /* Every 2.5f of mana the player loses,
         * equates to one charge on the mana bar being disabled.
         * Once the player regenerates the stamina,
         * the charge will be reenabled
         */
        if (totalMana <= 7.5f)
        {
            Charge1.SetActive(false);
        }
        else if (totalMana > 7.5f)
        {
            Charge1.SetActive(true);
        }

        if (totalMana <= 5f)
        {
            Charge2.SetActive(false);
        }
        else if (totalMana > 5f)
        {
            Charge2.SetActive(true);
        }

        if (totalMana <= 2.5f)
        {
            Charge3.SetActive(false);
        }
        else if (totalMana > 2.5f)
        {
            Charge3.SetActive(true);
        }

        /* If the player reaches zero stamina,
         * the final charge of the stamina bar is disabled, 
         * and they can no longer attack with stamina.
         * If they regenerate the stamina,
         * the charge will be reenabled, 
         * and they will be allowed to use the mana attack again
         */        
        if (totalMana <= 0f)
        {
            Charge4.SetActive(false);
            MagicAttack.canAttack = false;
        }
        else if (totalMana > 0f)
        {
            Charge4.SetActive(true);
            MagicAttack.canAttack = true;
        }
    }
}

