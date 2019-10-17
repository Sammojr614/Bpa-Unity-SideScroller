using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMainHub : MonoBehaviour {

	void OnMouseDown(){
		if (Input.GetMouseButtonDown (0)) {
			StartClickSensor.clicked = true;
			Cursor.visible = false;
			SceneManager.LoadScene ("MainHub");
		} else {
			if (Input.GetMouseButtonUp (0)) {
				StartClickSensor.clicked = false;
			}
		}
	}
}
