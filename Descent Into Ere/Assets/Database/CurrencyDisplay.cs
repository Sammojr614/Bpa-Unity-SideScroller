using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class CurrencyDisplay : MonoBehaviour
{
    public Text CurrencyDisplayText;
    private void Update()
    {
        string fromJson = File.ReadAllText("PlayerSaveData.json");
        DataMgr getCurrency = JsonUtility.FromJson<DataMgr>(fromJson);
        CurrencyDisplayText.text = getCurrency.Playercurrency.ToString();
    }
}
