using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBoxes2 : MonoBehaviour {
	Animator CheckBoxAnimator;
	// Use this for initialization
	void Start () {
		CheckBoxAnimator = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(LevelCompletion.LevelComplete == 2){
			CheckBoxAnimator.SetBool("LucidComplete", true);
		}else{
			if(LevelCompletion.LevelComplete < 2){
				CheckBoxAnimator.SetBool("LucidComplete", false);
			}
		}
	}
}
