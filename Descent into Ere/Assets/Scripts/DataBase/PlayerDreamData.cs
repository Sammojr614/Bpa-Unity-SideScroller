using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using System.IO;
using Mono.Data.Sqlite;

public class PlayerDreamData : MonoBehaviour {

	// Use this for initialization
	void Start () {
		IDbConnection dbCon = new SqliteConnection (TitleData.connectionString);
		dbCon.Open ();
		IDbCommand dbCmd = dbCon.CreateCommand ();
		string updateLocation = "UPDATE PlayerSaveData SET PlayerLocation='PlayerDream'";
		dbCmd.CommandText = updateLocation;
		dbCmd.ExecuteNonQuery ();
		dbCon.Close ();
	}
}
