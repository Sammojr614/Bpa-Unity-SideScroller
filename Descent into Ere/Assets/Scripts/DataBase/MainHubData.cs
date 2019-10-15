using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using Mono.Data.Sqlite;
using System.IO;

public class MainHubData : MonoBehaviour {
	// Use this for initialization
	void Start () {
		string connectionString = "Data Source = DieDatabase.db;Version=3;";
		IDbConnection dbCon = new SqliteConnection (connectionString);
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
