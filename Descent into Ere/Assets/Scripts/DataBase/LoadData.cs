using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using System.IO;
using Mono.Data.Sqlite;
using UnityEngine.SceneManagement;
using System;

public class LoadData : MonoBehaviour {
	void OnMouseDown(){
		if (Input.GetMouseButtonDown (0)) {
			StartClickSensor.clicked = true;
			IDbConnection dbCon = new SqliteConnection (SaveData.connectionString);
			dbCon.Open ();
			IDbCommand readerCmd = dbCon.CreateCommand ();
			IDataReader dbReader = readerCmd.ExecuteReader ();
			string loadData = "SELECT*FROM PlayerSaveData";
			readerCmd.CommandText = loadData;
			while (dbReader.Read ()) {
				PlayerLives.Lives = Convert.ToInt32 (dbReader [3].ToString ());
				PlayerHealth.health = Convert.ToInt32 (dbReader [2].ToString ());
			}
			dbReader.Close ();
			dbCon.Close ();
			
		} else {
			if(Input.GetMouseButtonUp(0)){
				StartClickSensor.clicked = false;
			}
			
		}
	}

}
	

