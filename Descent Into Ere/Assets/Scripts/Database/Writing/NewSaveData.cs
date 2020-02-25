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
        dataManager.DataCheck("SELECT name FROM sqlite_master");
        if (dataManager.isDataHere == false)
        {
            dataManager.normalDbCommand("CREATE TABLE PlayerSaveData(PlayerLocation TEXT, PlayerHealth INT, PlayerLives INT, PlayerCurrency INT, TimesPlayed INT)");
            dataManager.normalDbCommand("INSERT INTO PlayerSaveData(PlayerLocation, PlayerHealth,PlayerLives,PlayerCurrency, TimesPlayed)VALUES('MainHub','4','3','0','1')");
            dataManager.normalDbCommand("CREATE TABLE PlayerInventory(SlotNumber INT, ItemInSlot TEXT, NumberOfItem INT)");
            TutorialDialog.SetActive(true);
        }
    }
}
