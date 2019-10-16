using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using System.IO;
using Mono.Data.Sqlite;

public class TitleData : MonoBehaviour {
	public static string connectionString ="Data Source=DieDataBase.db;";
	// Use this for initialization
	void Start () {
		IDbConnection dbCon = new SqliteConnection (connectionString);
		IDbCommand dbCmd = dbCon.CreateCommand ();
		dbCon.Open ();
		string updateLocation = "UPDATE PlayerSaveData SET PlayerLocation='Title'";
		dbCmd.CommandText = updateLocation;
		dbCmd.ExecuteNonQuery ();
		dbCon.Close ();

	}
}
