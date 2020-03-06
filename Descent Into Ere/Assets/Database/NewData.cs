using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class NewData : MonoBehaviour
{
    public Button CreateButton;
    DataMgr Data = DataMgr.Instance;
    
    private void Start()
    {
        CreateButton.onClick.AddListener(taskOnClick);
    }
    void taskOnClick()
    {
        Data.TimesPlayed = 0;
        Data.location = "MainHub";
        Data.Playerhealth = 4;
        Data.PlayerLives = 3;
        string jsonData = JsonUtility.ToJson(Data);
        File.WriteAllText("PlayerSaveData.json",jsonData);
        
    }
}
