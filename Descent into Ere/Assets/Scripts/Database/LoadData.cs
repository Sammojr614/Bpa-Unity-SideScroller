using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System.IO;
using System;
using UnityEngine.SceneManagement;

public class LoadData : MonoBehaviour {
	SpriteRenderer SaveFile;
	void Start(){
		SaveFile = gameObject.GetComponent<SpriteRenderer> ();
	}
	void OnMouseDown(){
		if (Input.GetMouseButtonDown (0)) {
			readerQuery ("SELECT*FROM PlayerSaveData");
		}
	}



	public void runQuery(string sql){	
		using(SqliteConnection dbCon = new SqliteConnection(NewData.connectionString)){
			dbCon.Open();
			using(SqliteCommand dbCmd = new SqliteCommand(sql, dbCon)){
				dbCmd.ExecuteNonQuery();
			}
		}

	}
	public void readerQuery(string readText){
		using(SqliteConnection DbCon = new SqliteConnection(NewData.connectionString)){
			DbCon.Open();
			using(SqliteCommand DbCmd = new SqliteCommand(readText, DbCon)){
				using (SqliteDataReader dbReader = DbCmd.ExecuteReader ()) {
					if (dbReader.Read ()) {
						while (dbReader.Read ()) {
							SaveFile.enabled = true;
							PlayerHealth.health = Convert.ToInt32 (dbReader [2].ToString ());
							PlayerLives.Lives = Convert.ToInt32 (dbReader [3].ToString ());
							SceneManager.LoadScene (dbReader [0].ToString ());
						}
					} else {
						SaveFile.enabled = false;
					}
					
				}	
			}
	}
}
}
