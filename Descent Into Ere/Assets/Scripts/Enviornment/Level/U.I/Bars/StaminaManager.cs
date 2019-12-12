using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaminaManager : MonoBehaviour {

	public Animator StaminaAnimator;
    //Amount of stamina drained
	float Drain = TotalStamina - DrainofStamina;
	public static float DrainofStamina = 0.1f;
    //Total amount of stamina
	public static float TotalStamina = 10f;
    //Amount of stamina replensihed
	float Replenish = TotalStamina + DrainofStamina;

    //The three parts of the stamina bar
    public GameObject Tip;
    public GameObject Main;
    public GameObject EndTip;

    //On start, the stamina bar is full
    void Start()
    {
        Tip.SetActive(true);
        Main.SetActive(true);
        EndTip.SetActive(true);
    }

    void Update(){
        /*
        Debug.Log(TotalStamina);
        */       

        // If the player is sprinting, they will lose stamina
		if(Input.GetButton("Sprint")){
			if(TotalStamina != 0f){
                TotalStamina -= DrainofStamina; 
			}
        }
        else
        {
            /* If the players stamina bar is not full,
             * and they are not sprinting,
             * they will begin to replenish stamina over time
             */            
            if(TotalStamina < 10f)
            {
                TotalStamina += Replenish * Time.deltaTime;
            }
            //This prevents stamina going above 10f
            else
            {
                TotalStamina = 10f;
            }
        }
        /* If the player's stamina bar is empty,
         * the player is unable to sprint, or attack,
         * and the end of the stamina bar becomes empty
         */        
        if(TotalStamina <= 0f)
        {
            Sprint.canSprint = false;
            EndTip.SetActive(false);
            Knife.canAttack = false;
        }
        /* When the player's stamina bar is no longer empty,
         * the player can sprint and attack again,
         * and the end of the stamina bar becomes visible again
         */        
        else
        {
            Sprint.canSprint = true;
            EndTip.SetActive(true);
            Knife.canAttack = true;
        }
        /* If the player loses some of it's stamina,
         * the first part of the stamina bar,
         * becomes empty, if the player regains the stamina,
         * the first part of the stamina bar will become visible again
         */
        if(TotalStamina <= 7.5f)
        {
            Tip.SetActive(false);
        }
        else if(TotalStamina > 7.5f)
        {
            Tip.SetActive(true);
        }
        /* If the player loses most of it's stamina,
         * the middle of the stamina bar becomes empty,
         * if the player regains enough stamina,
         * the middle of the stamina bar,
         * becomes visible again
         */        
        if(TotalStamina <= 2.5f)
        {
            Main.SetActive(false);
        }
        else if(TotalStamina > 2.5f)
        {
            Main.SetActive(true);
        }
        if(Knife.damaged == true)
        {
            TotalStamina -= 5f;
        }


    }

}
