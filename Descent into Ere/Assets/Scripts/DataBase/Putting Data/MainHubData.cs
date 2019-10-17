using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using Mono.Data.Sqlite;
using System.IO;
public class MainHubData : MonoBehaviour {

	// Use this for initialization
	void Start () {
		IDbConnection dbCon = new SqliteConnection (TitleData.connectionString);
		dbCon.Open ();
		IDbCommand dbCmd = dbCon.CreateCommand ();
		string updateLocation = "UPDATE PlayerSaveData SET PlayerLocation='MainHub'";
		dbCmd.CommandText = updateLocation;
		dbCmd.ExecuteNonQuery ();
		dbCon.Close ();
	}
}
