using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLives : MonoBehaviour {

	public static int Lives;
	public Animator livesAnimator;
	void Start () {
		Lives = 3;
		 livesAnimator= GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		livesAnimator.SetFloat("SetLives",0.0f);
        if(PlayerHealth.health == 0 && Lives > 0){
			Lives--;
			
			PlayerHealth.health += 3;
		}
		if(Lives < 0){
			Lives = 0;
		}
		if(Lives == 3){
			livesAnimator.SetFloat("SetLives", 0.0f);
		}else{
		if(Lives == 2){
			livesAnimator.SetFloat("SetLives", 0.5f);
		}else{
			if(Lives == 1){
				livesAnimator.SetFloat("SetLives", 1.0f);
			}
		}
		}

	}
}
