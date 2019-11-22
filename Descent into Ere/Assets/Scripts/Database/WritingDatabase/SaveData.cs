using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using System.IO;
using Mono.Data.Sqlite;
using System;

public class SaveData : MonoBehaviour {
	public DbManager dataManager = DbManager.Instance;
	void OnMouseDown(){
   
		if(Input.GetMouseButtonDown(0)){
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
            //NumberOfPotions in Main PlayerSave Data
            dataManager.dbCommand(dataManager.connectionString, "UPDATE PlayerSaveData SET NumberOfPotions='" + Convert.ToInt32(Inventory.NumberOfPotions) + "'");
				//Saving the Amount of times played
				dataManager.dbCommand(dataManager.connectionString,"UPDATE PlayerSaveData SET TimesPlayed='"+ Convert.ToInt32(TutoralWallCheck.TimesPlayed) + "'");
                //Player Currency
                dataManager.dbCommand(dataManager.connectionString, "UPDATE PlayerSaveData Set PlayerCurrency='" + Convert.ToInt32(ShopTable.amountOfPlayerCurrency) + "'");
			/* Counter Table For The Currency */
			dataManager.dbCommand (dataManager.connectionString, "UPDATE Counter SET ThirdDidget='" + Convert.ToInt32(CrystalCounter.ThirdDiget) + "'");
			dataManager.dbCommand (dataManager.connectionString, "UPDATE Counter SET SecondDidget='" + Convert.ToInt32 (CrystalCounter.SecndDigt) + "'");
			dataManager.dbCommand (dataManager.connectionString, "UPDATE Counter SET FirstDidget='" + Convert.ToInt32 (CrystalCounter.FirstDigt) + "'");




                                /* Inventory Table */
			//Potion
			if (Inventory.NumberOfItems > 1 && Inventory.NumberOfPotions > 1) {
				dataManager.dbCommand(dataManager.connectionString, "UPDATE PlayerInventory SET ItemSlot1='Potion'");
					}else{
						if(Inventory.NumberOfItems == 0 || Inventory.NumberOfPotions == 0){
							dataManager.dbCommand(dataManager.connectionString, "UPDATE PlayerInventory SET ItemSlot1='None'");
						}
					} 
			//Normal Key
			if ( Inventory.haveKey == true) {
				dataManager.dbCommand (dataManager.connectionString, "UPDATE PlayerInventory SET ItemSlot2 ='NormalKey'");
			} else {
					dataManager.dbCommand(dataManager.connectionString,"UPDATE PlayerInventory SET ItemSlot2 ='None'");
			}
			//Boss Key
			if (Inventory.haveBossKey == true) {
				dataManager.dbCommand (dataManager.connectionString, "UPDATE PlayerInventory SET ItemSlot3='Boss Key'");
			} else {
				dataManager.dbCommand (dataManager.connectionString, "UPDATE PlayerInventory SET ItemSlot3='None'");
			}
            /* Key Management */
			//Normal Key
            if(Inventory.haveKey == true){
                dataManager.dbCommand(dataManager.connectionString, "UPDATE PlayerSaveData SET KeyInInventory='1'");
            }else{
                dataManager.dbCommand(dataManager.connectionString,"UPDATE PlayerSaveData SET KeyInInventory='0'");
            }
			//Boss Key
			string flag = Inventory.haveBossKey ? "1" : "0";
			dataManager.dbCommand (dataManager.connectionString, "UPDATE PlayerSaveData SET HaveBossKey='" + flag + "' ");

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
        }
    }
}
