using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using System.IO;
using Mono.Data.Sqlite;

public class SaveData : MonoBehaviour {
public static bool isThereData;
	// Use this for initialization
	void Start () {
		IDbConnection dbCon = new SqliteConnection(TitleData.connectionString);
		dbCon.Open();
		IDbCommand dbCmd = dbCon.CreateCommand();
		//Setting PlayerLocation
		string updateLocation = "UPDATE PlayerSaveData SET PlayerLocation='Saves'";
		dbCmd.CommandText = updateLocation;
		dbCmd.ExecuteNonQuery();
		IDbCommand cmdRead = dbCon.CreateCommand();
		string dataRead = "SELECT*FROM PlayerSaveData";
		cmdRead.CommandText = dataRead;
		IDataReader dbReader = cmdRead.ExecuteReader();
		//Checking if there is Data And if there isn't Add Some
		if(!dbReader.Read()){
			string addNewData = "INSERT INTO PlayerSaveData(PlayerLocation,PlayerItems,PlayerHealth,PlayerLives) VALUES('Saves','0','3','3')";
			cmdRead.CommandText = addNewData;
			cmdRead.ExecuteNonQuery();
		}
		dbReader.Close();
		dbCon.Close();

		
		
	}
}
