using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class LoadDisplay : MonoBehaviour
{
    DbManager dbMgr = DbManager.Instance;
    public GameObject Displayer;
    public Text LivesDisplay;
    public Text HealthDisplay;
    public Text CoinDisplay;

    private void Start()
    {
        if(File.Exists(Application.dataPath + "PlayerSaveData.json"))
        {
            Displayer.SetActive(true);
        }else if(!File.Exists(Application.dataPath + "PlayerSaveData.json"))
        {
            Displayer.SetActive(false);
        }
    }
    private void Update()
    {
        string fromDb = File.ReadAllText(Application.dataPath + "PlayerSaveData.json");
        DbManager loadStuff = JsonUtility.FromJson<DbManager>(fromDb);
        LivesDisplay.text = "Lives: " + loadStuff.dbLives.ToString();
        if(loadStuff.dbHealth == 6)
        {
            HealthDisplay.text = "Full";
        }else if(loadStuff.dbHealth == 3)
        {
            HealthDisplay.text = "Half";
        }else if(loadStuff.dbHealth == 1)
        {
            HealthDisplay.text = "Next to None";
        }
        CoinDisplay.text = loadStuff.dbCoins.ToString();
    }
}
