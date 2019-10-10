using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLives : MonoBehaviour {

	public static int Lives;
	public Animator PlayerAnimatior;
	void Start () {
		Lives = 3;
		PlayerAnimatior = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(PlayerHealth.health == 0){
			Lives--;
			PlayerHealth.health = 3;
		}
		if(Lives < 0){
			Lives = 0;
		}
	}
}
