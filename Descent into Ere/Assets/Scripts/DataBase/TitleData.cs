using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.IO;
using System.Data;

public class TitleData : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Connecting to Database
		string connectionString = "Data Source=DieDatabase.db";
		 IDbConnection dbCon = new SqliteConnection(connectionString);
		dbCon.Open ();
		//Commands
		IDbCommand dbCmd = dbCon.CreateCommand ();
		string findTable = "SELECT FROM PlayerSaveData";
		dbCmd.CommandText = findTable;
		//reader
		//Inserting Data
		string dataInsert = "INSERT INTO \"main\".\"LevelsComplete\"(\"PlayerDream\",\"Level2\",\"Level3\") VALUES (NULL,NULL,NULL)";
		dbCmd.CommandText = dataInsert;


		 
		 
	}
}
	
