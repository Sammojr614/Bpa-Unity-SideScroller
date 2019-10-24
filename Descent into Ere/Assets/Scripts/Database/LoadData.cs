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
            //Location Assignment
            dataManager.dbFindStringData(dataManager.connectionString, "SELECT*FROM PlayerSaveData", LocateMainHub.PlayerLocation, 0);
            //Health Assignment
            dataManager.dbFindIntData(dataManager.connectionString, "SELECT*FROM PlayerSaveData", PlayerHealth.health, 2);
            //Lives Assignment
            dataManager.dbFindIntData(dataManager.connectionString, "SELECT*FROM PlayerSaveData", PlayerLives.Lives, 3);
            SceneManager.LoadScene("MainHub");
			
		}
	}



	
}
