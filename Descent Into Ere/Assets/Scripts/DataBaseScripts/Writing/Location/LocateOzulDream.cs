using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LocateOzulDream : MonoBehaviour
{
    DataMgr data = DataMgr.Instance;
    InventoryMgr Inven = InventoryMgr.Instance;
    // Start is called before the first frame update
    void Update()
    {
        data.location = "OzulDream";
        data.Playerhealth = Health.health;
        data.PlayerLives = Health.lives;
        data.Playercurrency = CurrencyCounter.currentCoins;
        Inventory.NumberOfItems = Inven.NumberOfItem;
        Inven.ItemName = "Potion";

        string locationUpdate = JsonUtility.ToJson(data);
        string InvenUpdate = JsonUtility.ToJson(Inven);
        File.WriteAllText(Application.dataPath + "PlayerSaveData.json", locationUpdate);
        File.WriteAllText(Application.dataPath + "PlayerInventory.json", InvenUpdate);
    }

}
