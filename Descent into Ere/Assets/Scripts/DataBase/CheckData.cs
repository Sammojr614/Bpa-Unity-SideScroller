using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using Mono.Data.Sqlite;
using System.IO;

public class CheckData : MonoBehaviour {

	// Use this for initialization
	void Start () {
		IDbConnection dbCon = new SqliteConnection (SaveData.connectionString);
		dbCon.Open ();
		IDbCommand dbCmd = dbCon.CreateCommand ();
		IDataReader dbReader = dbCmd.ExecuteReader ();
		string dataCheck = "SELECT*FROM PlayerSaveData";
		dbCmd.CommandText = dataCheck;
		if (!dbReader.Read ()) {
			string putData ="INSERT INTO PlayerSaveData(PlayerLocation,PlayerItems,PlayerLives,PlayerHealth) VALUES('MainHub','0','3','3')";
			dbCmd.CommandText = putData;
		}
	}
	
}
