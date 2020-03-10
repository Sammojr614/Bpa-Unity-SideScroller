using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LocateOzulDream : MonoBehaviour
{
    DataMgr data = DataMgr.Instance;
    // Start is called before the first frame update
    void Start()
    {
        data.location = "OzulDream";
        data.Playerhealth = Health.health;
        data.PlayerLives = Health.lives;
        data.Playercurrency = CurrencyCounter.currentCoins;

        string locationUpdate = JsonUtility.ToJson(data);
        File.WriteAllText("PlayerSaveData.json", locationUpdate);
    }

}
