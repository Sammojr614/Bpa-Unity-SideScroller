using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using System.IO;
using Mono.Data.Sqlite;

public class NewData : MonoBehaviour {
	SpriteRenderer NewSave;
	void Start(){
		NewSave = gameObject.GetComponent<SpriteRenderer>();
		
	}
	public static string connectionString = "Data Source=DieDataBase.db";
	void OnMouseDown(){
		if(Input.GetMouseButtonDown(0)){
		IDbConnection dbCon = new SqliteConnection(connectionString);
		dbCon.Open();
		IDbCommand dbCmd = dbCon.CreateCommand();
		string CreateSaveTable = "CREATE TABLE PlayerSaveData(PlayerLocation TEXT ,PlayerProgress TEXT,PlayerHealth INTEGER, PlayerLives INTEGER);";
		dbCmd.CommandText = CreateSaveTable;
		dbCmd.ExecuteNonQuery();
		string addData = "INSERT INTO PlayerSaveData(PlayerLocation,PlayerProgress,PlayerHealth,PlayerLives) VALUES('MainHub','0%','3','3')";
		dbCmd.CommandText = addData;
		dbCmd.ExecuteNonQuery();
		}
	}
}
