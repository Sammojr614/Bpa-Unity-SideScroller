using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class MoveScenesWithButton2D : MonoBehaviour {
	DbManager dataManager = DbManager.Instance;
	string SceneName;
	public static string PrevScene;
	
	void Start(){
	}
	void OnMouseDown(){
		if(Input.GetMouseButtonDown(0)){
			dataManager.GetSceneNameFromDb("SELECT*FROM PlayerSaveData");
			SceneManager.LoadScene(PrevScene);
			string insertThis = string.Format("UPDATE ShopStock SET amountOfItem='{0}' WHERE Item='Potion'", Convert.ToInt32(ShopTable.NumberOfItems));
			dataManager.normalDbCommand(insertThis);
			dataManager.normalDbCommand("UPDATE PlayerSaveData SET PlayerCurrency='" + Convert.ToInt32(ShopTable.amountOfPlayerCurrency) + "'");
			Cursor.visible = false;
		}
	}
}
