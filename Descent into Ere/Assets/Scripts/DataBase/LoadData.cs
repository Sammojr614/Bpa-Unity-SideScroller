using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Data;
using System.IO;
using Mono.Data.Sqlite;
using System;

public class LoadData : MonoBehaviour {
	SpriteRenderer SaveFile;
	void Start(){
		SaveFile = gameObject.GetComponent<SpriteRenderer> ();
		IDbConnection dbCon = new SqliteConnection (NewData.connectionString);
		dbCon.Open ();
		IDbCommand dbCmd = dbCon.CreateCommand ();
		IDataReader dbReader;
		string checkForData = "SELECT*FROM PlayerSaveData";
		dbCmd.CommandText = checkForData;
		dbReader = dbCmd.ExecuteReader ();
		if (dbReader.Read ()) {
			SaveFile.enabled = true;
		} else {
			SaveFile.enabled = false;
		}
	}
	void OnMouseDown(){
		if (Input.GetMouseButtonDown (0)) {
			IDbConnection dbCon = new SqliteConnection (NewData.connectionString);
			dbCon.Open ();
			IDbCommand dbCmd = dbCon.CreateCommand ();
			IDataReader dbReader;
			string readData = "SELECT*FROM PlayerSaveData";
			dbCmd.CommandText = readData;
			dbReader = dbCmd.ExecuteReader ();
			while (dbReader.Read ()) {
				PlayerLives.Lives = Convert.ToInt32 (dbReader [3].ToString ());
				PlayerHealth.health = Convert.ToInt32 (dbReader [2].ToString ());
				SceneManager.LoadScene (dbReader [0].ToString ());
			}
		}
	}

}
