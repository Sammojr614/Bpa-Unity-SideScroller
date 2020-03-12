﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class CurrencyDisplay : MonoBehaviour
{
    public Text CurrencyDisplayText;
    DataMgr data = DataMgr.Instance;
    private void Update()
    {
        string fromJson = File.ReadAllText(Application.dataPath + "PlayerSaveData.json");
        DataMgr getCurrency = JsonUtility.FromJson<DataMgr>(fromJson);
        CurrencyDisplayText.text = getCurrency.Playercurrency.ToString();
        
    }
}
