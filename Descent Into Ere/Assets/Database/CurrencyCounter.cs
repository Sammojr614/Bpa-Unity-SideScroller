using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class CurrencyCounter : MonoBehaviour
{
    public Text CurrencyCounterD;
    DataMgr data = DataMgr.Instance;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Crystal"))
        {
            data.Playercurrency++;
            string currencyUpdate = JsonUtility.ToJson(data);
            File.WriteAllText(Application.dataPath + "/Database/PlayerSaveData.json", currencyUpdate);
        }
    }
}
