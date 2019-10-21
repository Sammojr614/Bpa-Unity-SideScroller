using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using System.IO;
using Mono.Data.Sqlite;

public class NewData : MonoBehaviour {
	public static string connectionString = "Data Source=DieDataBase.db";

	void OnMouseDown(){
		if(Input.GetMouseButtonDown(0)){
		IDbConnection dbCon = new SqliteConnection(connectionString);
		dbCon.Open();
		IDbCommand dbCmd = dbCon.CreateCommand();
		string AddData = "INSERT INTO PlayerSaveData(PlayerLocation,PlayerProgress,PlayerLives,PlayerHealth) VALUES('MainHub','0','3','3')";
		dbCmd.CommandText = AddData;
		dbCmd.ExecuteNonQuery();
		dbCon.Close();
		}
	}
	
	
}
