using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScenesWithButton2D : MonoBehaviour {
	DbManager dataManager = DbManager.Instance;
	public string SceneName;
	public static string PrevScene;
	
	void Start(){
	}
	void OnMouseDown(){
		if(Input.GetMouseButtonDown(0)){
			dataManager.loadPrevScene("SELECT*FROM PlayerSaveData");
			Debug.Log(PrevScene);
			SceneManager.LoadScene(PrevScene);
			string insertThis = string.Format("UPDATE ShopStock SET NumberOfItems={0} WHERE Items='Potion'", ShopTable.NumberOfItems);
			Debug.Log(ShopTable.NumberOfItems);
			dataManager.dbCommand(dataManager.connectionString,insertThis);
			Cursor.visible = false;
		}
	}
}
