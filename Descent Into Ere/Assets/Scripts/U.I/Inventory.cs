using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject InventoryMenu;
    InventoryMgr Inven = InventoryMgr.Instance;
    public Text ItemCounter;
    int NumberOfItems;
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
}
