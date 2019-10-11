using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartClickSensor : MonoBehaviour {

	public static bool clicked;
	SpriteRenderer startButton;
	void Start () {
		startButton = gameObject.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			clicked = true;
			startButton.enabled = false;
		}else{
			if(Input.GetMouseButtonUp(0)){
				clicked = false;
			}
		}
	}
}
