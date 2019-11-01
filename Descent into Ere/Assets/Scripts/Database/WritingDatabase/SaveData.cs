using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using System.IO;
using Mono.Data.Sqlite;
using System;

public class SaveData : MonoBehaviour {
    void OnMouseDown(){
        
            DbManager dataManager = DbManager.Instance;
		if(Input.GetMouseButtonDown(0)){
            dataManager.dbReaderTest(dataManager.connectionString,"SELECT*FROM PlayerSaveData",1);
                                                        /* Main Player Save Data */
            //Saving the Scene Name of Where the Player is
            dataManager.dbCommand(dataManager.connectionString,"UPDATE PlayerSaveData SET PlayerLocation=" + LocateMainHub.PlayerLocation);
            //Saving The Players Health
            dataManager.dbCommand(dataManager.connectionString, "UPDATE PlayerSaveData SET PlayerHealth='" + Convert.ToInt32(PlayerHealth.health) + "'");
            //Saving Lives As Well
            dataManager.dbCommand(dataManager.connectionString, "UPDATE PlayerSaveData SET PlayerLives='" + Convert.ToInt32(PlayerLives.Lives) + "'");
            //This Is For Saving Inventory Items
            //Saving Levels Complete
            dataManager.dbCommand(dataManager.connectionString, "UPDATE PlayerSaveData SET LevelsComplete='" + Convert.ToInt32(LevelCompletion.LevelComplete) + "'");
            //Number Of Inventory Items
            dataManager.dbCommand(dataManager.connectionString, "UPDATE PlayerSaveData SET ItemsInInventory='" + Convert.ToInt32(Inventory.NumberOfItems) + "'");
                                /* Inventory Table */
            if(Inventory.NumberOfItems == 1 && Inventory.NumberOfPotions >= 1 || Inventory.NumberOfPotions <= 3){
                dataManager.dbCommand(dataManager.connectionString, "UPDATE PlayerInventory SET ItemSlot1='Potion'");
            }else{
                if(Inventory.NumberOfItems == 1 && Inventory.haveKey == true){
                    dataManager.dbCommand(dataManager.connectionString, "UPDATE PlayerInventory SET ItemSlot1='Key'");
                }else{
                    if(Inventory.NumberOfPotions >= 1 && Inventory.haveKey == true){
                        dataManager.dbCommand(dataManager.connectionString, "UPDATE PlayerInventory SET ItemSlot1='Potion'");
                        dataManager.dbCommand(dataManager.connectionString, "UPDATE  PlayerInventory SET ItemSlot2='Key'");
                    }
                }
            }
            /* Key Management */
            if(Inventory.haveKey == true){
                dataManager.dbCommand(dataManager.connectionString, "UPDATE PlayerSaveData SET KeyInInventory='1'");
            }else{
                dataManager.dbCommand(dataManager.connectionString,"UPDATE PlayerSaveData SET KeyInInventory='0'");
            }
                                     /* Level Index */
       if(LevelCompletion.LevelComplete == 0){
           dataManager.dbCommand(dataManager.connectionString, "UPDATE LevelIndex SET PlayerDream='Incomplete'");
       }else{
            if(LevelCompletion.LevelComplete == 1){
            dataManager.dbCommand(dataManager.connectionString,"UPDATE LevelIndex SET PlayerDream='Complete'");
        }else{
            if(LevelCompletion.LevelComplete == 2){
                dataManager.dbCommand(dataManager.connectionString, "UPDATE LevelIndex SET Lucid='Complete'");
            }else{
                if(LevelCompletion.LevelComplete == 3){
                    dataManager.dbCommand(dataManager.connectionString, "UPDATE LevelIndex SET Level3='Complete'");
                }
            }
        }
       }
       /* Saving Player Inventory */
       if(Inventory.NumberOfItems == 2 && Inventory.NumberOfPotions >= 1){
           dataManager.dbCommand(dataManager.connectionString, "UPDATE PlayerInventory SET ItemSlot1 ='Potion'");
       }
        }
    }
}
