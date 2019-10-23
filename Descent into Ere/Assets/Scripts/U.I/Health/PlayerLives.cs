﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using System.IO;
using Mono.Data.Sqlite;
using System;
public class PlayerLives : MonoBehaviour {

	public static int Lives;
	public Animator livesAnimator;
	void Start () {
		IDbConnection dbCon = new SqliteConnection(DatabaseStatics.connectionString);
		dbCon.Open();
		IDbCommand dbCmd = dbCon.CreateCommand();
		IDataReader dbReader;
		string checklives = "SELECT PlayerLives FROM PlayerSaveData";
		dbCmd.CommandText = checklives;
		dbReader = dbCmd.ExecuteReader();
		while(dbReader.Read()){
			Lives = Convert.ToInt32(dbReader[0].ToString());
		}
		dbReader.Close();
		dbCon.Close();

	}
	
	
	void Update () {
		livesAnimator.SetFloat("SetLives",0.0f);
        if(PlayerHealth.health == 0 && Lives > 0){
			Lives--;
			
			PlayerHealth.health += 3;
		}
		if(Lives < 0){
			Lives = 0;
		}
		if(Lives == 3){
			livesAnimator.SetFloat("SetLives", 0.0f);
		}else{
		if(Lives == 2){
			livesAnimator.SetFloat("SetLives", 0.5f);
		}else{
			if(Lives == 1){
				livesAnimator.SetFloat("SetLives", 1.0f);
			}
		}
		}

	}
}
