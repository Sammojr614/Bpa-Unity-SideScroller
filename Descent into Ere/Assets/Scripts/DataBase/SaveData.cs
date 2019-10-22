using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using System.IO;
using Mono.Data.Sqlite;
using System;

public class SaveData : MonoBehaviour {
	void OnMouseDown(){
		if (Input.GetMouseButtonDown (0)) {
			IDbConnection dbCon = new SqliteConnection (NewData.connectionString);
			dbCon.Open ();
			//the Database Commands
			IDbCommand dbCmd = dbCon.CreateCommand();
			//The Command Text
			string updateLocation = "UPDATE PlayerSaveData SET PlayerLocation="+ LocationHandler.PlayerLocation;
			string updateHealth = "UPDATE PlayerSaveData SET PlayerHealth=" + PlayerHealth.health;
			string updateLives = "UPDATE PlayerSaveData SET PlayerLives=" + PlayerLives.Lives;
			//Updating Location
			dbCmd.CommandText = updateLocation;
			dbCmd.ExecuteNonQuery ();
			//Updating Health
			dbCmd.CommandText = updateHealth;
			dbCmd.ExecuteNonQuery ();
			//Updating Lives
			dbCmd.CommandText = updateLives;
			dbCmd.ExecuteNonQuery ();
			//Closing DataBase
			dbCon.Close();
		}
	}
}
