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
		//Checking if there is Data There
		 string levelDataCheck = "SELECT*FROM LevelData WHERE Level1 = 'Incomplete'";
		 dbCmd.CommandText = levelDataCheck;
		 dbCmd.ExecuteNonQuery();
		  //Adding Data To LevelData
		 string levelQury = "INSERT INTO LevelData(Level1,Level2,Level3) VALUES('Incomplete','Incomplete','Incomplete')";
		 dbCmd.CommandText = levelQury;
		 dbCmd.ExecuteNonQuery();
		 string playerQury = "INSERT INTO PlayerSaveData(PlayerLocation,PlayerItems,PlayerLives) VALUES('Title','None', '0')";
		 dbCmd.CommandText = playerQury;
		 dbCmd.ExecuteNonQuery();
		 dbCon.Close();
		 
		 
		 
	}
}
	
