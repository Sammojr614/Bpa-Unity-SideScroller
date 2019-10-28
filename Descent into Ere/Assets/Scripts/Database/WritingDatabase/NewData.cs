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
			//Creating the Table for The Main Player Save Data
            dataManager.dbCommand(dataManager.connectionString, "CREATE TABLE PlayerSaveData(PlayerLocation TEXT,PlayerProgress TEXT,PlayerHealth INTEGER,PlayerLives INTEGER)");
            dataManager.dbCommand(dataManager.connectionString, "INSERT INTO PlayerSaveData(PlayerLocation,PlayerProgress,PlayerHealth,PlayerLives) VALUES('MainHub','0%','3','3')");
			//Loading the Mainhub on First Save
			dataManager.loadSceneFromDB(dataManager.connectionString,"SELECT*FROM PlayerSaveData", LocateMainHub.PlayerLocation);
			//Making the Table For The Inventory
            dataManager.dbCommand(dataManager.connectionString, "CREATE TABLE PlayerInventory(ItemSlot1 TEXT, ItemSlot2 TEXT, ItemSlot3 TEXT, ItemSlot4 TEXT, ItemSlot5 TEXT)");
            dataManager.dbCommand(dataManager.connectionString, "INSERT INTO PlayerInventory(ItemSlot1,ItemSlot2,ItemSlot3,ItemSlot4,ItemSlot5) VALUES('None','None','None','None','None')");
			//Making a LevelIndex
			dataManager.dbCommand(dataManager.connectionString, "CREATE TABLE LevelIndex(PlayerDream TEXT, Lucid TEXT, Level3 TEXT)");
			dataManager.dbCommand(dataManager.connectionString, "INSERT INTO LevelIndex(PlayerDream,Lucid,Level3) VALUES('Incomplete','Incomplete','Incomplete')");
			
		}
	}

	


}
