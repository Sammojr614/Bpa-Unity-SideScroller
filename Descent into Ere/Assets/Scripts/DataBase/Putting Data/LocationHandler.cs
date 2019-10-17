using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using System.IO;
using Mono.Data.Sqlite;

public class LocationHandler : MonoBehaviour {
	public static string PlayerLocation;
	
	void Start () {
		IDbConnection dbCon = new SqliteConnection(TitleData.connectionString);
		dbCon.Open();
		IDataReader DbReader;
		IDbCommand cmdReader = dbCon.CreateCommand();
		string readLine = "SELECT PlayerLocation FROM PlayerSaveData";
		cmdReader.CommandText = readLine;
		DbReader = cmdReader.ExecuteReader();
		while(DbReader.Read()){
			PlayerLocation = DbReader[0].ToString();
		}
		DbReader.Close();
	}
	
	
}
