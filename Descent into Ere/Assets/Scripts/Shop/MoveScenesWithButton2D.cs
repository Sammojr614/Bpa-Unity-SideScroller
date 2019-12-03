using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScenesWithButton2D : MonoBehaviour {
	public string SceneName;
	DbManager dataManager = DbManager.Instance;
	void OnMouseDown(){
		if(Input.GetMouseButtonDown(0)){
			SceneManager.LoadScene(SceneName);
			string insertThis = string.Format("UPDATE ShopStock SET NumberOfItems={0} WHERE Items='Potion'", ShopTable.NumberOfItems);
			Debug.Log(ShopTable.NumberOfItems);
			dataManager.dbCommand(dataManager.connectionString,insertThis);
			Cursor.visible = false;
		}
	}
}
