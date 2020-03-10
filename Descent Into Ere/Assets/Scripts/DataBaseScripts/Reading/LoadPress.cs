using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class LoadPress : MonoBehaviour
{
    DataMgr data = DataMgr.Instance;
    public Button loadButton;
    public GameObject TutorialDialog;
    // Start is called before the first frame update
    void Start()
    {
        loadButton.onClick.AddListener(LoadOnClick);
        TutorialDialog.SetActive(false);
    }
    void LoadOnClick()
    {
        string forload = File.ReadAllText("PlayerSaveData.json");
        //Reading the File
        DataMgr Loaded = JsonUtility.FromJson<DataMgr>(forload);
        //Getting location
        SceneManager.LoadScene(Loaded.location);
        //Getting Health
        Health.health = Loaded.Playerhealth;
        //Getting Lives
        Health.lives = Loaded.PlayerLives;
        //Getting amount of Currency
        CurrencyCounter.currentCoins = Loaded.Playercurrency;
        //Times Played
        data.TimesPlayed++;
        //Updating stuff
        string updateTimesPlayed = JsonUtility.ToJson(data);
        File.WriteAllText("PlayerSaveData.json", updateTimesPlayed);
        if(Loaded.TimesPlayed == 0)
        {
            TutorialDialog.SetActive(true);
        }
        else
        {
            TutorialDialog.SetActive(false);
        }
    }

    
}
