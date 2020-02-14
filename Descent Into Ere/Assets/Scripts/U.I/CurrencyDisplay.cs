using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyDisplay : MonoBehaviour
{
    public Text CurrencyDisplayText;
    DbManager dataMgr = DbManager.Instance;
    // Update is called once per frame
    private void Start()
    {
        dataMgr.ReadingData("SELECT*FROM PlayerSaveData");
    }
    void Update()
    {
        CurrencyDisplayText.text = dataMgr.PlayerCurrency.ToString();
    }
}
