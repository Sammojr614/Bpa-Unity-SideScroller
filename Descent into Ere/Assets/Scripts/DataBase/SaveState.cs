using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using System.IO;
using Mono.Data.Sqlite;

public class SaveState : MonoBehaviour {
	void OnMouseDown(){
		if (Input.GetMouseButtonDown (0)) {
			StartClickSensor.clicked = true;
			IDbConnection dbCon = new SqliteConnection (NewData.connectionString);
			dbCon.Open ();
			IDbCommand dbCmd = dbCon.CreateCommand ();
			string updateLocation = "UPDATE PlayerSaveData SET PlayerLocation=" + LocationHandler.PlayerLocation;
			string updateHealth = "UPDATE PlayerSaveData SET PlayerHealth ='" + PlayerHealth.health + "'";
			string updateLives = "UPDATE PlayerSaveData SET PlayerLives='" + PlayerLives.Lives + "'";
			//Updating Location
			dbCmd.CommandText = updateLocation;
			dbCmd.ExecuteNonQuery ();
			//Updating Health
			dbCmd.CommandText = updateHealth;
			dbCmd.ExecuteNonQuery ();
			//Updating Lives
			dbCmd.CommandText = updateLives;
			dbCmd.ExecuteNonQuery ();
			dbCon.Close ();
		} else {
			if (Input.GetMouseButtonUp (0)) {
				StartClickSensor.clicked = false;
			}
		}
	}
}
