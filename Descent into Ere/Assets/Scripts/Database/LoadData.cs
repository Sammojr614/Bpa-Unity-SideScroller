using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System.IO;
using System;
using UnityEngine.SceneManagement;

public class LoadData : MonoBehaviour {
	SpriteRenderer SaveFile;
		DbManager dataManager = DbManager.Instance;
	
	void Start(){
	
	}
	void OnMouseDown(){
		if (Input.GetMouseButtonDown (0)) {
			dataManager.getDataTypeInteger(dataManager.connectionString,"SELECT*FROM PLayerSaveData",PlayerLives.Lives, 3);
			dataManager.getDataTypeString(dataManager.connectionString, "SELECT*FROM PlayerSaveData", LocateMainHub.PlayerLocation, 0);
			dataManager.getDataTypeInteger(dataManager.connectionString, "SELECT*FROM PlayerSaveData", PlayerHealth.health, 2);
			
		}
	}



	
}
