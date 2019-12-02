using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftAnimations : MonoBehaviour {
	public Animator PlayerAnimator;
	void Update () {
		if(Flipper.facingLeft == true){
			PlayerAnimator.SetBool("isFacingLeft", true);
		}else if(Flipper.facingLeft == false){
			PlayerAnimator.SetBool("isFacingLeft", false);
		}
	}
}
