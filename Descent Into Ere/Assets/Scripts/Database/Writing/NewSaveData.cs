using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewSaveData : MonoBehaviour
{
    public Button NewDataButton;
    DbManager dataManager = DbManager.Instance;

    private void Start()
    {
        NewDataButton.onClick.AddListener(taskOnClick);
    }
    void taskOnClick()
    {
        dataManager.DataCheck("SELECT name FROM sqlite_master");
        if (dataManager.isDataHere == false)
        {
            dataManager.normalDbCommand("CREATE TABLE PlayerSaveData(PlayerLocation TEXT, PlayerHealth INT, PlayerLives INT, PlayerCurrency INT)");
            dataManager.normalDbCommand("INSERT INTO PlayerSaveData(PlayerLocation, PlayerHealth,PlayerLives,PlayerCurrency)VALUES('MainHub','4','3','0')");
            dataManager.normalDbCommand("CREATE TABLE PlayerInventory(SlotNumber INT, ItemInSlot TEXT, NumberOfItem INT)");
        }
    }
}
