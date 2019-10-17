using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Data;
using Mono.Data.Sqlite;
using UnityEngine.SceneManagement;

public class SaveFile1 : MonoBehaviour {
	SpriteRenderer fileOne;
	
void Start(){
	fileOne = gameObject.GetComponent<SpriteRenderer>();
}
	private void OnMouseDown(){
		if(Input.GetMouseButtonDown(0)){
			StartClickSensor.clicked = true;
			IDbConnection dbCon = new SqliteConnection(TitleData.connectionString);
			dbCon.Open();
			IDbCommand readCmd = dbCon.CreateCommand();
			IDataReader dbReader = readCmd.ExecuteReader();
			string dataCheck = "SELECT*FROM PlayerSaveData";
			readCmd.CommandText = dataCheck;
			while(dbReader.Read()){
				SceneManager.LoadScene(dbReader[0].ToString());
			}
			Cursor.visible = false;
			fileOne.enabled = false;

		}else{
			if(Input.GetMouseButtonUp(0)){
				StartClickSensor.clicked = false;
			}
		}

	}
	
	
}

