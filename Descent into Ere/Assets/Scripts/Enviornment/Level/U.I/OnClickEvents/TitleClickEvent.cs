using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleClickEvent : MonoBehaviour {

	public Animator TitleAnimator;
	void Start () {
		TitleAnimator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(StartClickSensor.clicked == true){
			TitleAnimator.SetBool("StartButtonClicked", true);
		}
	}
}
