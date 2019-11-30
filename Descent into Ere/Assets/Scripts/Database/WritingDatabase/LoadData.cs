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
		SaveFile = gameObject.GetComponent<SpriteRenderer>();
		dataManager.RendererState(dataManager.connectionString,"SELECT sql FROM main.sqlite_master;", SaveFile, true, false);
	}
	void OnMouseDown(){
		if (Input.GetMouseButtonDown (0)) {
            //Location Assignment
           dataManager.loadSceneFromDB(dataManager.connectionString,"SELECT*FROM PlayerSaveData", LocateMainHub.PlayerLocation);
		   //Getting Health and Lives, and Levels Complete
		   dataManager.loadIntData(dataManager.connectionString,"SELECT*FROM PlayerSaveData");
		   //Saying what Happens if You Have a Key
			dataManager.CountingFromDb("SELECT*FROM Counter");
		   if(dataManager.TrueOrFalseFromdb == 0){
			   Inventory.haveKey = false;
		   }else{
			   if(dataManager.TrueOrFalseFromdb == 1){
				   Inventory.haveKey = true;
					Inventory.NumberOfItems = Inventory.NumberOfItems+1;
			   }
		   }if(dataManager.BosskeyTrueOrFalse == 0){
			   Inventory.haveBossKey = false;

		   }else{
			   if(dataManager.BosskeyTrueOrFalse == 1){
				   Inventory.haveBossKey = true;
				   Inventory.NumberOfItems = Inventory.NumberOfItems+1;

			   }
		   }
		   
		}
	}



	
}

