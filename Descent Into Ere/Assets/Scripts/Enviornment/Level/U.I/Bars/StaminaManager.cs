using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaminaManager : MonoBehaviour {
	public Animator StaminaAnimator;
	int Drain = TotalStamina - DrainofStamina;
	public static int DrainofStamina = 1;
	public static int TotalStamina = 10;
	int Replenish = TotalStamina + DrainofStamina;
	
	void Update(){
		if(Input.GetButtonDown("Sprint")){
			if(TotalStamina != 0){
				TotalStamina = Drain;
			}
		}else if(Input.GetButtonUp("Sprint")){
			while(TotalStamina <= 10){
				TotalStamina = Replenish;
			}
		}
	}

}
