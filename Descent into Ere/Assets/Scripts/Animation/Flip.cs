using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour {
	//Giving the Code The Player 
	public GameObject Player;
	//Animator
	Animator PlayerAnimator;
	//Animation
	Animation PlayerAnimation;


	void Start () {
		Player = GetComponent<GameObject> ();
		PlayerAnimator = Player.GetComponent<Animator> ();
		PlayerAnimation = PlayerAnimator.GetComponent<Animation> ();
	}
	

	void Update () {
		if (Input.GetButtonDown ("MoveRight")) {
			
		}
	}
}
