using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaminaManager : MonoBehaviour {
	public Animator StaminaAnimator;
	float Drain = TotalStamina - DrainofStamina;
	public static float DrainofStamina = 0.1f;
	public static float TotalStamina = 10f;
	float Replenish = TotalStamina + DrainofStamina;
	
	void Update(){
        Debug.Log(TotalStamina);

		if(Input.GetButton("Sprint")){
			if(TotalStamina != 0f){
                TotalStamina -= DrainofStamina; 
			}
        }
        else
        {
            if(TotalStamina < 10f)
            {
                TotalStamina += Replenish;
            }
            else
            {
                TotalStamina = 10f;
            }
        }
        if(TotalStamina <= 0f)
        {
            Sprint.canSprint = false;
        }
        else
        {
            Sprint.canSprint = true;
        }

    }

}
