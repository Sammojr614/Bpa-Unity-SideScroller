using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyDisplay : MonoBehaviour
{
    public Text CurrencyDisplayText;
    DbManager dataMgr = DbManager.Instance;
    
    private void Start()
    {
        dataMgr.ReadingData("SELECT*FROM PlayerSaveData");
    }
    void Update()
    {
        //This just makes it so The Int From the database is changed into a string so the Text Feild can Use it
        CurrencyDisplayText.text = dataMgr.PlayerCurrency.ToString();
        CurrencyDisplayText.text = Shop.PlayerCrystals.ToString();
        Debug.Log(Shop.PlayerCrystals);
    }
}
