using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeponAnimator : MonoBehaviour {

	public Animator WeponAnimation;
	
	
	void Update () {
		if(Input.GetButton("SwordAttack")){
			WeponAnimation.SetFloat("Attacking", 0.5f);
		}else if(WeaponActive.KnifeDrawn == true){
			WeponAnimation.SetFloat("Attacking", 1.0f);
			WeponAnimation.SetFloat("Attacking", 0.0f);
		}else if(WeaponActive.KnifeDrawn == false){
			WeponAnimation.SetFloat("Attacking", 1.0f);
		}

	}
}
