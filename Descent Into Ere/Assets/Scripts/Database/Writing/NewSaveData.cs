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
            //Putting DataTables into the Database
            dataManager.normalDbCommand("CREATE TABLE PlayerSaveData(PlayerLocation TEXT, PlayerHealth INT, PlayerLives INT, PlayerCurrency INT, TimesPlayed INT)");
            dataManager.normalDbCommand("INSERT INTO PlayerSaveData(PlayerLocation, PlayerHealth,PlayerLives,PlayerCurrency, TimesPlayed)VALUES('MainHub','4','3','0','1')");
            dataManager.normalDbCommand("CREATE TABLE PlayerInventory(SlotNumber INT, ItemInSlot TEXT, NumberOfItem INT)");
            dataManager.normalDbCommand("CREATE TABLE LevelIndex(OzulDreamComplete INT, LucidComplete INT, NightMareComplete INT)");
            dataManager.normalDbCommand("INSERT INTO LevelIndex(OzulDreamComplete, LucidComplete, NightmareComplte) VALUES('0','0', '0')");
            TutorialDialog.SetActive(true);
        }
    }
}
