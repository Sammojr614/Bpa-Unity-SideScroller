using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class CurrencyCounter : MonoBehaviour
{
    public GameObject Coin;
    public static int currentCoins;

    DataMgr data = DataMgr.Instance;
    private void Start()
    {
        Coin.SetActive(true);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            data.Playercurrency++;
            string currencyUpdate = JsonUtility.ToJson(data);
            File.WriteAllText("PlayerSaveData.json", currencyUpdate);
            Coin.SetActive(false);
        }
    }

    private void Update()
    {
        currentCoins = data.Playercurrency;
    }
}
