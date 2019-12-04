using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScenesWithButton2D : MonoBehaviour {
	DbManager dataManager = DbManager.Instance;
	public string SceneName;
	public string PrevScene;
	
	void Start(){
	dataManager.dbFindStringData(dataManager.connectionString, "SELECT*FROM PlayerSaveData", PrevScene, 0 );
	}
	void OnMouseDown(){
		if(Input.GetMouseButtonDown(0)){
			SceneManager.LoadScene(PrevScene);
			string insertThis = string.Format("UPDATE ShopStock SET NumberOfItems={0} WHERE Items='Potion'", ShopTable.NumberOfItems);
			Debug.Log(ShopTable.NumberOfItems);
			dataManager.dbCommand(dataManager.connectionString,insertThis);
			Cursor.visible = false;
		}
	}
}
