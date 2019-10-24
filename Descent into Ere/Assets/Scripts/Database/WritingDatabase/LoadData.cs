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
		dataManager.RendererState(dataManager.connectionString,"SELECT*FROM PlayerSaveData", SaveFile, true, false);
	}
	void OnMouseDown(){
		if (Input.GetMouseButtonDown (0)) {
            //Location Assignment
           dataManager.loadSceneFromDB(dataManager.connectionString,"SELECT*FROM PlayerSaveData", LocateMainHub.PlayerLocation);
		   dataManager.loadIntData(dataManager.connectionString,"SELECT*FROM PlayerSaveData");
		   
        
           
		}
	}



	
}

