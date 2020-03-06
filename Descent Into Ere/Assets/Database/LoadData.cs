using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class LoadData : MonoBehaviour
{
    public Text LoctionDisplay;
    public Text LivesDisplay;
    public Text HealthDisplay;
    public Text Currecny;
    public Text TimesPlayed;
    // Start is called before the first frame update
    void Start()
    {
        string forDisplay = File.ReadAllText(Application.dataPath + "/Database/PlayerSaveData.json");
        DataMgr LoadedData = JsonUtility.FromJson<DataMgr>(forDisplay);
        LoctionDisplay.text ="Locaition: " + LoadedData.location;
        LivesDisplay.text = "Lives: " + LoadedData.PlayerLives.ToString();
        HealthDisplay.text = "Health: " + LoadedData.PlayerLives.ToString();
        Currecny.text = "Dream Coins: " + LoadedData.Playercurrency.ToString();
        TimesPlayed.text = "TimesPlayed: " + LoadedData.TimesPlayed.ToString();
    }
   


}
