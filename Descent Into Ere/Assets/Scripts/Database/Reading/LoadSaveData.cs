using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadSaveData : MonoBehaviour
{
    public Text LocationDisplay;
    public Text HealthDisplay;
    public Text LivesDisplay;
    public Button LoadButton;
    public Text Buttontext;
    public Text DreamCoinText;
    public Text NumberOfTimesPlayed;
    public static string SceneToBeLoaded;
    DbManager datamanager = DbManager.Instance;
    void Start()
    {
        datamanager.DataCheck("SELECT name FROM sqlite_master WHERE name = 'PlayerSaveData'");
        if(datamanager.isDataHere == true) {
            datamanager.ReadingData("SELECT*FROM PlayerSaveData");
            LoadButton.onClick.AddListener(TaskOnClick);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
       if(datamanager.isDataHere == true)
        {
            LocationDisplay.text = "Location: " + datamanager.PlayerLocation;
            LivesDisplay.text = "Lives: " + datamanager.PlayerLives.ToString();
            HealthDisplay.text = "Health: " + datamanager.PlayerHealth.ToString();
            DreamCoinText.text = "Dream Coins: " + datamanager.PlayerCurrency.ToString();
            NumberOfTimesPlayed.text = "Times Played: " + OpenThingy.TimesPlayed.ToString();
        }else if(datamanager.isDataHere != true)
        {
            LocationDisplay.text = "Location: Unknown";
            LivesDisplay.text = "Lives: Unknown";
            HealthDisplay.text = "Health: Unknown";
            DreamCoinText.text = "Dream Coins: Unknown";
            Buttontext.text = "No Save Data";
            LoadButton.enabled = false;
            NumberOfTimesPlayed.text = "0";
        }
    }
    void TaskOnClick()
    {
        datamanager.LoadSceneFromDb("SELECT*FROM PlayerSaveData");
    }
}
