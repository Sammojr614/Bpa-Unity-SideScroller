using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Data;
using Mono.Data.Sqlite;
using UnityEngine.SceneManagement;

public class SaveFile1 : MonoBehaviour {
	SpriteRenderer fileOne;
	
void Start(){
	fileOne = gameObject.GetComponent<SpriteRenderer>();
}
	private void OnMouseDown(){
		StartClickSensor.clicked = true;
		if(Input.GetMouseButtonDown(0)){
		 SceneManager.LoadScene("MainHub");
		 Cursor.visible = false;
		}else{
			if(Input.GetMouseButtonUp(0)){
				StartClickSensor.clicked = false;
			}
		}

	}
	
	
}

