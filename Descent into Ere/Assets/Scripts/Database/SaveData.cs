using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using System.IO;
using Mono.Data.Sqlite;
using System;

public class SaveData : MonoBehaviour {
        DbManager dataManager = DbManager.Instance;
    void OnMouseDown(){
		if(Input.GetMouseButtonDown(0)){
            dataManager.dbCommand(dataManager.connectionString,"UPDATE PlayerSaveData SET PlayerLocation=" + LocateMainHub.PlayerLocation);
            dataManager.dbCommand(dataManager.connectionString, "UPDATE PlayerSaveData SET PlayerHealth=" + Convert.ToInt32(PlayerHealth.health));
            dataManager.dbCommand(dataManager.connectionString, "UPDATE PlayerSaveData SET PlayerLives=" + Convert.ToInt32(PlayerLives.Lives));
		}
		}

	}
