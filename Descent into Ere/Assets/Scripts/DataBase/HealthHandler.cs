using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Data;
using Mono.Data.Sqlite;

public class HealthHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
		IDbConnection dbCon = new SqliteConnection(TitleData.connectionString);
		dbCon.Open();
		IDbCommand dbCmd = dbCon.CreateCommand();
		//Two Hearts
		if(PlayerHealth.health == 2){
			string Updatehealth = "UPDATE PlayerSaveData SET PlayerHealth='2'";
			dbCmd.CommandText = Updatehealth;
			dbCmd.ExecuteNonQuery();
		}else{
			//One Heart
			if(PlayerHealth.health == 1){
				string updateHealth = "UPDATE PlayerSaveData SET PlayerHealth='1'";
				dbCmd.CommandText = updateHealth;
				dbCmd.ExecuteNonQuery();
			}else{
				//Three Hearts
				if(PlayerHealth.health == 3){
					string updatehealth = "UPDATE PlayerSaveData SET PlayerHealth='3'";
					dbCmd.CommandText = updatehealth;
					dbCmd.ExecuteNonQuery();
				}
			}
		}
		//Three Lives
		if(PlayerLives.Lives == 3){
			string UpdateLives = "UPDATE PlayerSaveData SET PlayerLives ='3'";
			dbCmd.CommandText = UpdateLives;
			dbCmd.ExecuteNonQuery();
		}else{
			//Two Lives
			if(PlayerLives.Lives == 2){
				string updateLives = "UPDATE PlayerSaveData SET PlayerLives='2'";
				dbCmd.CommandText = updateLives;
				dbCmd.ExecuteNonQuery();
			}else{
				//One Life
				if(PlayerLives.Lives == 1){
					string updatelives = "UPDATE PlayerSaveData SET PlayerLives='1'";
					dbCmd.CommandText = updatelives;
					dbCmd.ExecuteNonQuery();
				}
			}
		}
	}
}
