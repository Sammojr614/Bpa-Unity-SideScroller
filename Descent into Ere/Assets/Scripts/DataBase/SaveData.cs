using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Data;
using System;
using Mono.Data.Sqlite;

public class SaveData : MonoBehaviour {

	void OnMouseDown(){
		if(Input.GetMouseButtonDown(0)){
			IDbConnection dbCon = new SqliteConnection(NewData.connectionString);
			dbCon.Open();
			IDbCommand dbCmd = dbCon.CreateCommand();
			string updateLocation = "UPDATE PlayerSaveData SET PlayerLocation=" +LocationHandler.PlayerLocation;
			string updateHealth = "UPDATE PlayerSaveData SET PlayerHealth="+PlayerHealth.health;
			string updateLives = "UPDATE PlayerSaveData SET PlayerLives="+PlayerLives.Lives;
			//Updating Location
			dbCmd.CommandText = updateLocation;
			dbCmd.ExecuteNonQuery();
			//Updating Lives
			dbCmd.CommandText = updateLives;
			dbCmd.ExecuteNonQuery();
			//Updating Health
			dbCmd.CommandText = updateHealth;
			dbCmd.ExecuteNonQuery();
			dbCon.Close();
		}
	}
}
