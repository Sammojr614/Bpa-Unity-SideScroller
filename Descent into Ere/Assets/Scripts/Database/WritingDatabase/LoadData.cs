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
		public static string PlayerProgress;
	    
		
	void Start(){
		SaveFile = gameObject.GetComponent<SpriteRenderer>();
		dataManager.RendererState(dataManager.connectionString,"SELECT*FROM PlayerSaveData", SaveFile, true, false);
		if(PlayerProgress == "33%"){
			LevelDoorController.LucidLocked = true;
		}else{
			if(PlayerProgress == "66"){
				LevelDoorController.LucidLocked = false;
			}
		}
	}
	void OnMouseDown(){
		if (Input.GetMouseButtonDown (0)) {
            //Location Assignment
           dataManager.loadSceneFromDB(dataManager.connectionString,"SELECT*FROM PlayerSaveData", LocateMainHub.PlayerLocation);
		   //Getting Health and Lives
		   dataManager.loadIntData(dataManager.connectionString,"SELECT*FROM PlayerSaveData");
		   //Telliong the Game About the Player's Progress
		   dataManager.loadStringFromDb(dataManager.connectionString,"SELECT*FROM PlayerSaveData", PlayerProgress, 1);
		}
	}



	
}

