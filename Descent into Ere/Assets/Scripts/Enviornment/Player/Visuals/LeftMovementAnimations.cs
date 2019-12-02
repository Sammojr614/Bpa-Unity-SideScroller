using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftMovementAnimations : MonoBehaviour {
	public Animator PlayerAnimator;
	public static bool FaceingLeft;
	void Update () {
		if(Input.GetButton("MoveLeft")){
			FaceingLeft = true;
			PlayerAnimator.SetBool("isFacingLeft", FaceingLeft);
		}else if(Input.GetButton("MoveRight")){
			FaceingLeft = false;
			PlayerAnimator.SetBool("isFacingLeft", FaceingLeft);
		}
	}
}
