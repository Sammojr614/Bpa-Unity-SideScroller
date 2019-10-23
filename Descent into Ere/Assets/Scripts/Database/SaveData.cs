using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using System.IO;
using Mono.Data.Sqlite;

public class SaveData : MonoBehaviour {
	void OnMouseDown(){
		if (Input.GetMouseButtonDown(0)) {
			//updating Location
			UpdateQuery ("UPDATE PlayerSaveData SET PlayerLocation="+ LocateMainHub.PlayerLocation);
			//Updating Health
			UpdateQuery ("UPDATE PlayerSaveData SET PlayerHealth="+PlayerHealth.health);
			//Updating Lives
			UpdateQuery("UPDATE PlayerSaveData SET PlayerLives="+PlayerLives.Lives);
		}

	}
	public void UpdateQuery(string commandText){
		using(SqliteConnection dbCon = new SqliteConnection(NewData.connectionString)){
			dbCon.Open ();
			using (SqliteCommand dbCmd = new SqliteCommand (commandText, dbCon)) {
				dbCmd.ExecuteNonQuery ();
			}
		}
	}
}
