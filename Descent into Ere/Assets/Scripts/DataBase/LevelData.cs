using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Mono.Data.Sqlite;
using System.Data;
using System.IO;

public class LevelData : MonoBehaviour {
	void Start(){
		string connectionString = "Data Source =DieDataBase.db";
		IDbConnection dbCon = new SqliteConnection(connectionString);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
