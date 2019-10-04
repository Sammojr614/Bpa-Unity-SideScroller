using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnimationController : MonoBehaviour {
	public string animationName;
	void Update(){
		if(Input.GetKey("d")){
			GetComponent<Animator>().SetTrigger(animationName);
		}
	}