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
			IDbCommand dbCmd = dbCon.CreateCommand ();
			//Location Update
			string updateLocation = "UPDATE PlayerSaveData SET PlayerLocation=" + LocationHandler.PlayerLocation;
			dbCmd.CommandText = updateLocation;
			dbCmd.ExecuteNonQuery ();
			//Health Update
			string updateHealth = "UPDATE PlayerSaveData SET PlayerHealth=" + PlayerHealth.health;
			dbCmd.CommandText = updateHealth;
			dbCmd.ExecuteNonQuery ();
			//Lives Update
			string updateLives = "UPDATE PlayerSaveData SET PlayerLives="+ PlayerLives.Lives;
			dbCmd.CommandText = updateLives;
			dbCmd.ExecuteNonQuery ();
		}
	}
}
