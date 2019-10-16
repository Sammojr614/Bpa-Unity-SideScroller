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
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
