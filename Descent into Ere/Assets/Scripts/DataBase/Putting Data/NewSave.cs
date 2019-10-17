using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using System.IO;
using Mono.Data.Sqlite;

public class NewSave : MonoBehaviour {

	// Use this for initialization
	void OnMouseDown(){
		if(Input.GetMouseButtonDown(0)){
			IDbConnection dbCon = new SqliteConnection(TitleData.connectionString);
			dbCon.Open();
			IDbCommand dbCmd = dbCon.CreateCommand();
			string createNewSave = "INSERT INTO PlayerSaveData(PlayerLocation,PlayerItems,PlayerHealth,PlayerLives) VALUES('MainHub','0','3','3')";
			dbCmd.CommandText = createNewSave;
			dbCmd.ExecuteNonQuery();
		}
	}
	
	
}
