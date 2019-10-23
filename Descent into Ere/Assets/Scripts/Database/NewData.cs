using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using System.IO;
using Mono.Data.Sqlite;

public class NewData : MonoBehaviour {
 public static string connectionString = "Data Source=DieDataBase.db";
	void OnMouseDown(){
		if (Input.GetMouseButtonDown (0)) {
			runQuery("CREATE TABLE PlayerSaveData(PlayerLocation TEXT,PlayerProgress TEXT,PlayerHealth INTEGER,PlayerLives INTEGER)");
			runQuery("INSERT INTO PlayerSaveData(PlayerLocation,PlayerProgress,PlayerHealth,PlayerLives) VALUES('MainHub','0%','3','3')");
		}
	}

	public void runQuery(string sql){	
		using(SqliteConnection dbCon = new SqliteConnection(connectionString)){
		dbCon.Open();
		using(SqliteCommand dbCmd = new SqliteCommand(sql, dbCon)){
				dbCmd.ExecuteNonQuery();
		}
	}

	}


}
