using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Data;
using Mono.Data.Sqlite;

public class SettingData : MonoBehaviour {

	// Use this for initialization
	void Start () {
		IDbConnection dbCon = new SqliteConnection(TitleData.connectionString);
		dbCon.Open();
		IDbCommand cmdRead = dbCon.CreateCommand();
		IDataReader dbReader = cmdRead.ExecuteReader();
		string readTable = "SELECT*FROM PlayerSaveData";
		cmdRead.CommandText = readTable;
		while(dbReader.Read()){
			PlayerHealth.health =  Convert.ToInt32(dbReader[4].ToString());
			PlayerLives.Lives = Convert.ToInt32(dbReader[3].ToString());
		}
	}
	
	
}
