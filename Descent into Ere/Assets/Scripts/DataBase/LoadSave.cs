using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using System.IO;
using Mono.Data.Sqlite;
using System;

public class LoadSave : MonoBehaviour {
	SpriteRenderer SaveFile;
	IDbConnection dbCon = new SqliteConnection(NewData.connectionString);
	// Use this for initialization
	void Start () {
		SaveFile = gameObject.GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		dbCon.Open ();
		IDbCommand dbCmd = dbCon.CreateCommand ();
		IDataReader dbReader = dbCmd.ExecuteReader ();
		string checkData = "SELECT*FROM PlayerSaveData";
		dbCmd.CommandText = checkData;
		if (dbReader.Read ()) {
			SaveFile.enabled = true;
		} else {
			SaveFile.enabled = false;
		}
		dbReader.Close ();


		
	}
	void OnMouseDown(){
		if (Input.GetMouseButtonDown (0)) {
			StartClickSensor.clicked = true;
				dbCon.Open();
			IDbCommand dbCmd = dbCon.CreateCommand ();
			IDataReader dbReader = dbCmd.ExecuteReader ();
			string ReadData = "SELECT*FROM PlayerSaveData";
			dbCmd.CommandText = ReadData;
			while (dbReader.Read ()) {
				PlayerHealth.health = Convert.ToInt32 (dbReader [3].ToString ());
				PlayerLives.Lives = Convert.ToInt32 (dbReader [2].ToString ());
			}
			dbReader.Close ();
			dbCon.Close ();
		} else {
			if (Input.GetMouseButtonUp (0)) {
				StartClickSensor.clicked = false;
			}
		}
	}
}
