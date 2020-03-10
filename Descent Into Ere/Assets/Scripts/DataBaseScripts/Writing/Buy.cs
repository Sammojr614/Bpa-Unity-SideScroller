using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class Buy : MonoBehaviour
{
    InventoryMgr Inven = InventoryMgr.Instance;
    DataMgr data = DataMgr.Instance;
    public Button BuyButton;
    public int PriceofItem;
    private void Start()
    {
        BuyButton.onClick.AddListener(BuyOnClick);
    }
    private void Update()
    {
        if(Inven.NumberOfItem >= 3)
        {
            BuyButton.enabled = false;
        }
        else
        {
            BuyButton.enabled = true;
        }
    }
    void BuyOnClick()
    {
       
        
        string moneycheck = File.ReadAllText("PlayerInventory.json");
        DataMgr YesorNo = JsonUtility.FromJson<DataMgr>(moneycheck);
        if(YesorNo.Playercurrency >= PriceofItem)
        {
            string tojson = JsonUtility.ToJson(Inven);
            File.WriteAllText("PlayerInventory.json", tojson);
            int afterbuy = data.Playercurrency - PriceofItem;
            data.Playercurrency = afterbuy;
            string alsojson = JsonUtility.ToJson(data);
            File.WriteAllText("PlayerSaveData", alsojson);
        }
        else
        {
            BuyButton.enabled = false;
        }

    }
}
