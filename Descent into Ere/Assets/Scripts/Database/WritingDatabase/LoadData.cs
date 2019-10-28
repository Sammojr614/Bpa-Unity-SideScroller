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
	}
	void OnMouseDown(){
		if (Input.GetMouseButtonDown (0)) {
            //Location Assignment
           dataManager.loadSceneFromDB(dataManager.connectionString,"SELECT*FROM PlayerSaveData", LocateMainHub.PlayerLocation);
		   //Getting Health and Lives, and Levels Complete
		   dataManager.loadIntData(dataManager.connectionString,"SELECT*FROM PlayerSaveData");
		   //Telliong the Game About the Player's Progress
		   dataManager.loadStringFromDb(dataManager.connectionString,"SELECT*FROM PlayerSaveData", PlayerProgress, 1);
        
		                     /*LevelIndex*/
		   //This One is For PlayerDream
		   dataManager.loadLevelFromDb("SELECT PlayerDream FROM LevelIndex");
		   if(PlayerProgress == "Complete"){
			   LevelCompletion.LevelComplete = 1;
		   }
		   //This One is For Lucid
		   dataManager.loadLevelFromDb("SELECT Lucid FROM LevelIndex");
		   if(PlayerProgress == "Complete"){
			   LevelCompletion.LevelComplete = 2;
		   }
		   //This one is For The Third Level
		   dataManager.loadLevelFromDb("SELECT Level3 FROM LevelIndex");
		   if(PlayerProgress == "Complete"){
			   LevelCompletion.LevelComplete = 3;
		   }
		}
	}



	
}

