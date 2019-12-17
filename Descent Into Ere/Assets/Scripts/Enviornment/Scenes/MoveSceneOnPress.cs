using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveSceneOnPress : MonoBehaviour {

public string SceneName;
	void OnMouseDown(){
		if(Input.GetMouseButtonDown(0)){
			SceneManager.LoadScene(SceneName);
		}
	}
}
