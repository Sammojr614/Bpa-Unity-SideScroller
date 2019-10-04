using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatonController : MonoBehaviour {
	//calling Out the animator and The Bools Needed
	public Animator Animator;
	public GameObject Player;
	bool isMoving;
	bool isJumping;
	bool sprintActive;

	void Start () {
		Animator = Player.GetComponent<Animator> ();


	}
	

	void Update () {
		//Key code D
		if(Input.GetKey(KeyCode.D)){
			isMoving = true;
			Animator.SetBool ("Moving", isMoving);
		}
		//Key code A
		if(Input.GetKey(KeyCode.A)){
			isMoving = true;
			Animator.SetBool ("Moving", isMoving);
		}
		//Left Arrow Key
		if(Input.GetKey(KeyCode.LeftArrow)){
			isMoving = true;
			Animator.SetBool ("Moving", isMoving);
		}
		//Right Arrow Key
		if(Input.GetKey(KeyCode.RightArrow)){
			isMoving = true;
			Animator.SetBool ("Moving", isMoving);
		}
		isMoving = false;
		Animator.SetBool ("Moving", isMoving);
		//Left Shift
		if (Input.GetKey (KeyCode.LeftShift)) {
			sprintActive = true;
			Animator.SetBool ("Sprinting", sprintActive);
		} else {
			sprintActive = false;
			Animator.SetBool ("Sprinting", sprintActive);
		}
		//Right Shift
		if (Input.GetKey (KeyCode.RightShift)) {
			sprintActive = false;
			Animator.SetBool ("Sprinting", sprintActive);
		} else {
			sprintActive = false;
			Animator.SetBool ("Sprinting", sprintActive);
		}
		//Space
		if(Input.GetKey(KeyCode.Space)){
			isJumping = true;
			Animator.SetBool ("In Air", isJumping);
		}
		isJumping = false;
		Animator.SetBool ("In Air", isJumping);
	}
}

