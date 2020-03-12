using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class Shopmodifier : MonoBehaviour
{
    public Button buyButton;
    public int priceOfItem;
    DataMgr data = DataMgr.Instance;
    InventoryMgr inven = InventoryMgr.Instance;
    private void Start()
    {
        buyButton.onClick.AddListener(buyOnClick);
    }
    void buyOnClick()
    {
        if (CurrencyCounter.currentCoins >= priceOfItem)
        {
            int afterBuy = CurrencyCounter.currentCoins - priceOfItem;
            data.Playercurrency = afterBuy;
            data.Playerhealth = Health.health;
            data.PlayerLives = Health.lives;
            string toJson = JsonUtility.ToJson(data);
            File.WriteAllText(Application.dataPath + "PlayerSaveData.json", toJson);
            string fromJson = File.ReadAllText(Application.dataPath + "PlayerSaveData.json");
            DataMgr update = JsonUtility.FromJson<DataMgr>(fromJson);
            update.Playercurrency = CurrencyCounter.currentCoins;
            update.Playerhealth = Health.health;
            update.PlayerLives = Health.lives;
            inven.ItemName = "Potion";
            inven.NumberOfItem++;
            string inventoJson = JsonUtility.ToJson(inven);
            File.WriteAllText(Application.dataPath + "PlayerInventory.json",inventoJson);
        }
    }
}
