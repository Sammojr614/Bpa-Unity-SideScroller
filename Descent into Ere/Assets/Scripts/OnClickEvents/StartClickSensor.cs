using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            Cursor.visible = false;
            SceneManager.LoadScene("MainHub");
		}else{
			if(Input.GetMouseButtonUp(0)){
				clicked = false;
			}
		}
	}
}
