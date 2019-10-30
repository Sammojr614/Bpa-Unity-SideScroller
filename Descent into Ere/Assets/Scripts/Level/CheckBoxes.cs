using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBoxes : MonoBehaviour {
Animator CheckBoxAnimator;
public static bool CheckBoxisChecked;
	// Use this for initialization
	void Start () {
		CheckBoxAnimator = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		CheckBoxisChecked = CheckBoxAnimator.GetBool("Checked");
		if(LevelCompletion.LevelComplete == 0){
			CheckBoxAnimator.SetBool("PlayerDreamComplete", false);
		}else{
			if(LevelCompletion.LevelComplete == 1){
				CheckBoxAnimator.SetBool("PlayerDreamComplete", true);
			}
		}
	}
}
