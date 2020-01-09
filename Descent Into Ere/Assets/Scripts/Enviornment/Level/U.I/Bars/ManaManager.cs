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

    void Start()
    {
        totalMana = 10f;
    }

    void Update()
    {
        Debug.Log(totalMana);
        if (Input.GetButtonDown("ManaAttack"))
        {
            if(totalMana != 0f && MagicAttack.canAttack == true)
            {
                totalMana -= 2.5f;
            }
        }
        else
        {
            if (totalMana < 10f)
            {
                totalMana += regenTime * Time.deltaTime * 5;
            }
            else
            {
                totalMana = 10f;
            }
        }

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

    /*
	void Update(){
		if(Input.GetButtonDown("ManaAttack")){
			chargesUsed++;
			if(chargesUsed == 4){
					Charges[3].SetActive(false);
			}else if(chargesUsed == 3){
						Charges[2].SetActive(false);
				}else if(chargesUsed == 2){
					Charges[1].SetActive(false);
				}else if(chargesUsed == 1){
						Charges[0].SetActive(false);
					}
			if(chargesUsed >= 4){
				while(chargesUsed >= 0){
					if(chargesUsed == 3){
						Charges[3].SetActive(true);
					}else if(chargesUsed == 2){
						Charges[2].SetActive(true);
					}else if(chargesUsed == 1){
						Charges[1].SetActive(true);
					}else if(chargesUsed == 0){
						Charges[0].SetActive(true);
					}
					chargesUsed--;
				}
			}

            if(chargesUsed == 4)
            {
                MagicAttack.canAttack = false;
            }
            else
            {
                MagicAttack.canAttack = true;
            }

        }
	}
	*/
}

