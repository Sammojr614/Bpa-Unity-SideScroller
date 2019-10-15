using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.IO;
using System.Data;

public class TitleData : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Connecting to Database
		string connectionString = "Data Soruce=file:" + Application.persistentDataPath + "/Bpa-Project_Database/DieDatabase.db";
		 IDbConnection dbCon = new SqliteConnection(connectionString);
		Debug.Log(connectionString);
		 
		 
	}
}
	
