using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using System.IO;
using Mono.Data.Sqlite;
using System;
using UnityEngine.SceneManagement;

public class LoadData : MonoBehaviour {

	SpriteRenderer SaveFile;
	void Start () {
		SaveFile = gameObject.GetComponent<SpriteRenderer>();
		IDbConnection dbCon = new SqliteConnection(NewData.connectionString);
		dbCon.Open();
		IDataReader dbReader;
		IDbCommand dbCmd = dbCon.CreateCommand();
		string CheckData = "SELECT*FROM PlayerSaveData";
		dbCmd.CommandText = CheckData;
		dbReader = dbCmd.ExecuteReader();
		if(dbReader.Read()){
			SaveFile.enabled = true;
		}else{
			SaveFile.enabled = false;
		}
	}
	void OnMouseDown(){
		if(Input.GetMouseButtonDown(0) && SaveFile.enabled == true){
			IDbConnection dbCon  = new SqliteConnection(NewData.connectionString);
			dbCon.Open();
			IDataReader dbReader;
			IDbCommand dbCmd = dbCon.CreateCommand();
			string GetData = "SELECT*FROM PlayerSaveData";
			dbCmd.CommandText = GetData;
			dbReader = dbCmd.ExecuteReader();
			while(dbReader.Read()){
				PlayerHealth.health = Convert.ToInt32(dbReader[2].ToString());
				PlayerLives.Lives = Convert.ToInt32(dbReader[3].ToString());
				SceneManager.LoadScene(dbReader[0].ToString());
			}

		}
	}
}
