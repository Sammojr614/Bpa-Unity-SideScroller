using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Mono.Data.Sqlite;
using System.Data;
using System;
using UnityEngine.SceneManagement;

public class SaveData : MonoBehaviour {
	public static string connectionString = "Data Source=DieDataBase.db;";

	void Start () {
		IDbConnection dbCon = new SqliteConnection (connectionString);
		dbCon.Open ();
		IDbCommand dbCmd = dbCon.CreateCommand ();
		IDbCommand readCmd = dbCon.CreateCommand ();
		IDataReader dbReader = readCmd.ExecuteReader ();
		string CheckData = "SELECT*FROM PlayerSaveData";
		readCmd.CommandText = CheckData;
		//Checking For Data
		if (!dbReader.Read ()) {
			string AddSaveData = "INSERT INTO PlayerSaveData(PlayerLocation,PlayerItems,PlayerLives,PlayerHealth) VALUES('MainHub','0','3','3')";
			dbCmd.CommandText = AddSaveData;
			dbCmd.ExecuteNonQuery ();
		} else {
			dbReader.Close ();
		}
	}

	void OnMouseDown(){
		if (Input.GetMouseButtonDown (0)) {
			IDbConnection dbCon = new SqliteConnection (connectionString);
			dbCon.Open ();
			IDbCommand dbCmd = dbCon.CreateCommand ();
			//Location Update
			string UpdateLocation = "UPDATE PlayerSaveData SET PlayerLocation='" + MainhubLocation.PlayerLocation +"'";
			dbCmd.CommandText = UpdateLocation;
			dbCmd.ExecuteNonQuery ();
			//Health Update
			string UpdateHealth = "UPDATE PlayerSaveData SET PlayerHealth='" + Convert.ToInt32(PlayerHealth.health) + "'";
			dbCmd.CommandText = UpdateHealth;
			dbCmd.ExecuteNonQuery ();
			//Lives Update
			string UpdateLives ="UPDATE PlayerSaveData SET PlayerLives='" + Convert.ToInt32(PlayerLives.Lives) +"'";
			dbCmd.CommandText = UpdateLives;
			dbCmd.ExecuteNonQuery ();
		}
	}
}
