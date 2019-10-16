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

		string connectionString = "Data Source=DieDataBase.db;";
		 IDbConnection dbCon = new SqliteConnection(connectionString);
		 dbCon.Open();
		 IDbCommand dbCmd = dbCon.CreateCommand();
		 string qury = "INSERT INTO LevelData(Level1,Level2,Level3) VALUES('Incomplete','Incomplete','Incomplete')";
		 dbCmd.CommandText = qury;
		 dbCmd.ExecuteNonQuery();
		 
		 
		 
	}
}
	
