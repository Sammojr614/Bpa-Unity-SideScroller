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
            //Saving the Scene Name of Where the Player is
            dataManager.dbCommand(dataManager.connectionString,"UPDATE PlayerSaveData SET PlayerLocation=" + LocateMainHub.PlayerLocation);
            //Saving The Players Health
            dataManager.dbCommand(dataManager.connectionString, "UPDATE PlayerSaveData SET PlayerHealth=" + Convert.ToInt32(PlayerHealth.health));
            //Saving Lives As Well
            dataManager.dbCommand(dataManager.connectionString, "UPDATE PlayerSaveData SET PlayerLives=" + Convert.ToInt32(PlayerLives.Lives));
            //This Is For Saving Inventory Items
            if(Inventory.NumberOfItems >= 1 && Inventory.NumberOfItems <= 3)
            {
                dataManager.dbCommand(dataManager.connectionString, "UPDATE PlayerInventory SET ItemSlot1='Potion'");
            }
            else
            {
                dataManager.dbCommand(dataManager.connectionString, "UPDATE PlayerInventory SET ItemSlot1='None'");
            }
		}
		}

	}
