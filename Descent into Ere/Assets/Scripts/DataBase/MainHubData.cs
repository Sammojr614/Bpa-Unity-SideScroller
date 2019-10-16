using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using Mono.Data.Sqlite;
using System.IO;

public class MainHubData : MonoBehaviour {
	public static int LevelsComplete;
	void Start () {
		//Connecting to The DataBase
		string connectionString = "Data Source = DieDatabase.db;";
		IDbConnection dbCon = new SqliteConnection (connectionString);
		dbCon.Open();
		IDbCommand dbCmd = dbCon.CreateCommand();
		//Setting Player Data
		string tableaddQury = "UPDATE PlayerSaveData SET PlayerLocation = MainHub, PlayerItems = None";
		dbCmd.CommandText = tableaddQury;
		dbCmd.ExecuteNonQuery();
		//Setting Level Data
		if(LevelsComplete == 1){
			//One Level Complete
		string levelCompletequry1 = "UPDATE LevelData SET Level1 = 'Complete', Level2 = 'Incomplete', Level3 ='Incomplete'";
		dbCmd.CommandText = levelCompletequry1;
		dbCmd.ExecuteNonQuery();
		}else{
			if(LevelsComplete == 2){
				//Two Levels Complete
				string levelCompletequry2 = "UPDATE LevelData SET Level1 = 'Complete', Level2='Complete', Level3='Incomplete'";
				dbCmd.CommandText = levelCompletequry2;
				dbCmd.ExecuteNonQuery();
			}else{
				if(LevelsComplete == 3){
					string levelCompletequry3 = "UPDATE LevelData SET Level1 = 'Complete', Level2 ='Complete' ,Level3 = 'Complete'";
					dbCmd.CommandText = levelCompletequry3;
					dbCmd.ExecuteNonQuery();
				}
			}
		}
		dbCon.Close();
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
