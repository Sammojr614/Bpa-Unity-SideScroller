using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject InventoryMenu;
    public Button useButton;
    InventoryMgr Inven = InventoryMgr.Instance;
    DataMgr data = DataMgr.Instance;
    public Text ItemCounter;
    public static int NumberOfItems;
    public string nameOfItem;
    private void Start()
    {
        InventoryMenu.SetActive(false);
        string toJson = JsonUtility.ToJson(Inven);
        File.WriteAllText("PlayerInventory.json", toJson);
    }
    private void Update()
    {
        if (Input.GetButtonDown("Inventory"))
        {
            InventoryMenu.SetActive(true);
            string toLoad = File.ReadAllText("PlayerInventory.json");
            InventoryMgr load = JsonUtility.FromJson<InventoryMgr>(toLoad);
            NumberOfItems = load.NumberOfItem;
            nameOfItem = load.ItemName;
            if(NumberOfItems != 0)
            {
                ItemCounter.text = load.NumberOfItem.ToString();
            }
        }
    }
    void useOnClick()
    {
        string potionCheck = File.ReadAllText("PlayerInvetory.json");
        InventoryMgr invenCheck = JsonUtility.FromJson<InventoryMgr>(potionCheck);
        if(invenCheck.NumberOfItem != 0)
        {
            invenCheck.NumberOfItem--;
            Health.health++;
            data.Playerhealth = Health.health;
        }
        string inventorytojson = JsonUtility.ToJson(invenCheck);
        data.PlayerLives = Health.lives;
        data.Playercurrency = CurrencyCounter.currentCoins;
        string heal = JsonUtility.ToJson(data);
        File.WriteAllText("PlayerInventory.json",inventorytojson);
        File.WriteAllText("PlayerSaveData.json", heal);
    }
}
