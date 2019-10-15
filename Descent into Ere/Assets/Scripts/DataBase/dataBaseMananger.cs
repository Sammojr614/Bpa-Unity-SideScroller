using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System.IO;

public class dataBaseMananger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		IDbCommand dbCommand;
		IDataReader dbReader;
		string dataCon = "URL=file:"+ Application.persistentDataPath + "/Bpa-Project_DataBase/DieDatabase.db";
		IDbConnection dbCon  = new SqliteConnection(dataCon);
		dbCon.Open();

		
		/*string selectTable = "SELECT*FROM PlayerSaveData";
		dbCommand = dbCon.CreateCommand();
		dbCommand.CommandText = selectTable;
		dbReader = dbCommand.ExecuteReader();*/
		
	
		

		
	}
}
	
	