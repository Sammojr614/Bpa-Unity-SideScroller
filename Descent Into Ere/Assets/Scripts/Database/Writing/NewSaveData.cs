using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewSaveData : MonoBehaviour
{
    public Button NewDataButton;
    DbManager dataManager = DbManager.Instance;
    public GameObject TutorialDialog;

    private void Start()
    {
        NewDataButton.onClick.AddListener(taskOnClick);
        TutorialDialog.SetActive(false);
    }
    void taskOnClick()
    {
        //This Checks if There are Tables in the Created Database
        dataManager.DataCheck("SELECT name FROM sqlite_master");
        if (dataManager.isDataHere == false)
        {
                                                                    /* Main Player Save Data*/ 
            //Creating the Table
            dataManager.normalDbCommand("CREATE TABLE PlayerSaveData(PlayerLocation TEXT, PlayerHealth INT, PlayerLives INT, PlayerCurrency INT, TimesPlayed INT)");
            //Inserting the Default Values
            dataManager.normalDbCommand("INSERT INTO PlayerSaveData(PlayerLocation, PlayerHealth,PlayerLives,PlayerCurrency, TimesPlayed)VALUES('MainHub','4','3','0','1')");
            //Creating the Player Inventory 
            dataManager.normalDbCommand("CREATE TABLE PlayerInventory(SlotNumber INT, ItemInSlot TEXT, NumberOfItem INT)");

                                                        /*LevelIndex*/
            //Table Creation
            dataManager.normalDbCommand("CREATE TABLE LevelIndex(LevelName TEXT, Checkpoint INT, BossDefeated INT)");
            //Modifying the Table 
            dataManager.normalDbCommand("INSERT INTO LevelIndex(LevelName,Checkpoint, BossDefeated) VALUES('OzulDream', '0','0')");
            dataManager.normalDbCommand("INSERT INTO LevelIndex(LevelName, Checkpoint, BossDefeated) VALUES('Lucid', '0','0')");
            dataManager.normalDbCommand("INSERT INTO LevelIndex(LevelName, Checkpoint, BossDefeated) VALUES('Nightmare', '0','0')");
            // For that Extra Bit Of Swag, Asking if the need a tutoiral 
            TutorialDialog.SetActive(true);
        }
    }
}
