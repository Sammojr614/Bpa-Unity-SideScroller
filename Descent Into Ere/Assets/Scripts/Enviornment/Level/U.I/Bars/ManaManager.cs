using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaManager : MonoBehaviour {
	public GameObject[] Charges;
	int chargesUsed;
	void Start(){
		chargesUsed = 0;
	}
	void Update(){
		if(chargesUsed == 0){
			foreach(var charge in Charges){
				for(var i = 0; i < Charges.Length; i++){
				Charges[i].SetActive(true);
				}
			}
		}
		if(Input.GetButtonDown("ManaAttack")){
			if(chargesUsed <= 2){
				Charges[chargesUsed].SetActive(false);
				chargesUsed++;
			}else if(chargesUsed == 3){
				while(chargesUsed >= -1){
					Charges[chargesUsed].SetActive(true);
					chargesUsed--;
					if(chargesUsed == 0){
						chargesUsed = 0;
						break;
					}
				}
			}
		}
	}
}

