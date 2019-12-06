using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadData : MonoBehaviour {
DbManager dataManager = DbManager.Instance;
public static string LoadScene;
	void OnMouseDown(){
		if(Input.GetMouseButtonDown(0)){
			dataManager.GetSceneNameFromDb("SELECT*FROM PlayerSaveData");
			SceneManager.LoadScene(LoadScene);
			dataManager.gettingSavedIntData("SELECT*FROM PlayerSaveData");
			dataManager.setFromPlayerPerams("SELECT*FROM PlayerPerams");
		}
	}
}
