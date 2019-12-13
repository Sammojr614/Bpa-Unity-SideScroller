using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadData : MonoBehaviour {
DbManager dataManager = DbManager.Instance;
public static string LoadScene;
public static int loadBool;
public static bool PlayerHaveKnifeUpgrade;
	void OnMouseDown(){
		if(Input.GetMouseButtonDown(0)){
			dataManager.GetSceneNameFromDb("SELECT*FROM PlayerSaveData");
			SceneManager.LoadScene(LoadScene);
			dataManager.gettingSavedIntData("SELECT*FROM PlayerSaveData");
			dataManager.setFromPlayerPerams("SELECT*FROM PlayerPerams");
			dataManager.DbCounting("SELECT*FROM Money");
			dataManager.levelCheck("SELECT*FROM Levels");
			dataManager.UpgradeCheck("SELECT*FROM Upgrades", loadBool);
			if(loadBool == 1){
				PlayerHaveKnifeUpgrade = true;
			}else if(loadBool == 0){
				PlayerHaveKnifeUpgrade = false;
			}
		}
	}
}
