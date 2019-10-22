using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using System.IO;
using Mono.Data.Sqlite;

public class NewData : MonoBehaviour {
 public static string connectionString = "Data Source=DieDataBase.db";
	void Start(){
		Debug.Log("here");
		runQuery("CREATE TABLE PlayerSaveData");
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
