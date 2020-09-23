using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class NewData : MonoBehaviour
{
    public Button NewDataButton;
    DbManager dataMgr = DbManager.Instance;
   
    private void Start()
    {
        NewDataButton.onClick.AddListener(createData);
    }
    private void Update()
    {
        if(File.Exists(Application.dataPath + "PlayerSaveData.json"))
        {
            NewDataButton.gameObject.SetActive(false);
        }
        else if(!File.Exists(Application.dataPath + "PlayerSaveData.json"))
        {
            NewDataButton.gameObject.SetActive(true);
        }
    }
    void createData()
    {
        dataMgr.dbHealth = 6;
        dataMgr.dbLives = 4;
        dataMgr.dbLocation = "Testing";
        dataMgr.dbCoins = 0;
        string jsonString = JsonUtility.ToJson(dataMgr);
        File.WriteAllText(Application.dataPath + "PlayerSaveData.json",jsonString);
    }
}
