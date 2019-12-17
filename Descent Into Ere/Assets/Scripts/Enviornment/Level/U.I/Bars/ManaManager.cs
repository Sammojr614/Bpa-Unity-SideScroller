using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaManager : MonoBehaviour {
public GameObject[] Charges;
public static int chargesUsed;

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
}

