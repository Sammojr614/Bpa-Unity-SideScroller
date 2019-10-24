using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using System.IO;
using Mono.Data.Sqlite;
using UnityEngine.SceneManagement;

public class NewData : MonoBehaviour {
 SpriteRenderer CreateData;
    DbManager dataManager = DbManager.Instance;
 void Start(){
	 CreateData = gameObject.GetComponent<SpriteRenderer>();
	
 }
 void OnMouseEnter(){
	  dataManager.RendererState(dataManager.connectionString, "SELECT*FROM PlayerSaveData", CreateData, false,true);
 }
 void OnMouseExit(){
	  dataManager.RendererState(dataManager.connectionString, "SELECT*FROM PlayerSaveData", CreateData, false,true);
 }
 	void OnMouseDown(){
		if (Input.GetMouseButtonDown (0)) {
            dataManager.dbCommand(dataManager.connectionString, "CREATE TABLE PlayerSaveData(PlayerLocation TEXT,PlayerProgress TEXT,PlayerHealth INTEGER,PlayerLives INTEGER)");
            dataManager.dbCommand(dataManager.connectionString, "INSERT INTO PlayerSaveData(PlayerLocation,PlayerProgress,PlayerHealth,PlayerLives) VALUES('MainHub','0%','3','3')");
			dataManager.loadSceneFromDB(dataManager.connectionString,"SELECT*FROM PlayerSaveData", LocateMainHub.PlayerLocation);
			
		}
	}

	


}
