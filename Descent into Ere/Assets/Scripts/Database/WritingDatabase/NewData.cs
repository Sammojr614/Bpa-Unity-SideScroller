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
void OnMouseOver(){
	dataManager.RendererState(dataManager.connectionString, "SELECT sql FROM main.sqlite_master;", CreateData, false, true);
}
 
 	void OnMouseDown(){
		if (Input.GetMouseButtonDown (0)) {
			//Creating the Table for The Main Player Save Data
            dataManager.dbCommand(dataManager.connectionString, "CREATE TABLE PlayerSaveData(PlayerLocation TEXT,LevelsComplete INTEGER,ItemsInInventory INTEGER,NumberOfPotions INTEGER,KeyInInventory INTEGER,HaveBossKey INTEGER,PlayerHealth INTEGER,PlayerLives INTEGER, TimesPlayed INTEGER, PlayerCurrency INTEGER)");
            dataManager.dbCommand(dataManager.connectionString, "INSERT INTO PlayerSaveData(PlayerLocation,LevelsComplete,ItemsInInventory,NumberOfPotions,KeyInInventory,HaveBossKey,PlayerHealth,PlayerLives, TimesPlayed) VALUES('MainHub','0','0','0','0','0','3','3','0',)");
			//Setting Lives 
			dataManager.getLivesFromDb(dataManager.connectionString,"SELECT*FROM PlayerSaveData");
			//Loading the Mainhub on First Save
			SceneManager.LoadScene("Tutoral1");
			//Making the Table For The Inventory
            dataManager.dbCommand(dataManager.connectionString, "CREATE TABLE PlayerInventory(ItemSlot1 TEXT, ItemSlot2 TEXT, ItemSlot3 TEXT, ItemSlot4 TEXT, ItemSlot5 TEXT)");
            dataManager.dbCommand(dataManager.connectionString, "INSERT INTO PlayerInventory(ItemSlot1,ItemSlot2,ItemSlot3,ItemSlot4,ItemSlot5) VALUES('None','None','None','None','None')");
			//Making a LevelIndex
			dataManager.dbCommand(dataManager.connectionString, "CREATE TABLE LevelIndex(PlayerDream TEXT, Lucid TEXT, Level3 TEXT)");
			dataManager.dbCommand(dataManager.connectionString, "INSERT INTO LevelIndex(PlayerDream,Lucid,Level3) VALUES('Incomplete','Incomplete','Incomplete')");
			//Making a Switch Index
			dataManager.dbCommand(dataManager.connectionString, "CREATE TABLE SwitchIndex(SwitchId INTEGER,SwitchLocation TEXT,SwitchActive INTEGER, SwitchType TEXT)");
			//Whats In The Shop
			dataManager.dbCommand(dataManager.connectionString, "CREATE TABLE ShopStock(Items TEXT, NumberOfItems INTEGER, CostOfItem INTEGER)");

			
			
			
			
		}
	}

	


}
