using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour {
	public Animator PauseMenuAnimator;
	public static bool pauseButtonClicked;
	void Start () {
		PauseMenuAnimator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			pauseButtonClicked = true;
		}else{
			if(Input.GetMouseButtonUp(0)){
				pauseButtonClicked = false;
			}
		}
			}
		}


