using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Data;
using Mono.Data.Sqlite;

public class NewData : MonoBehaviour {
	public static string connectionString = "Data Source=DieDataBase.db;";
	void OnMouseDown(){
		if (Input.GetMouseButtonDown (0)) {
			StartClickSensor.clicked = true;
			IDbConnection dbCon = new SqliteConnection (connectionString);
			dbCon.Open ();
			IDbCommand dbCmd = dbCon.CreateCommand ();
			string addData = "INSERT INTO PlayerSaveData(PlayerLocation,PlayerItems,PlayerLives,PlayerHealth) VALUES('MainHub','0','3','3')";
			dbCmd.CommandText = addData;
			dbCmd.ExecuteNonQuery ();
			dbCon.Close ();

		} else {
			if (Input.GetMouseButtonUp (0)) {
				StartClickSensor.clicked = false;
			}
		}
	}
}
