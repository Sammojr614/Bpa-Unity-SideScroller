using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject InventoryMenu;
    public GameObject[] InventorySlots;
    public Button CloseButton;
    public static int NumberOfItems;
    public static int NumberOfPotions;
    public Text HowManyPotions;
    DbManager dbMgr = DbManager.Instance;
    // Start is called before the first frame update
    void Start()
    {
        InventoryMenu.SetActive(false);
        CloseButton.onClick.AddListener(CloseOnClick);
    }

    // Update is called once per frame
    void Update()
        
    {
        
        if (Input.GetButtonDown("Inventory"))
        {
            HowManyPotions.text = dbMgr.PotionsForDisplay.ToString();
            InventoryMenu.SetActive(true);
            Cursor.visible = true;
            dbMgr.CheckInventory("SELECT*FROM PlayerInventory");
        }
        if(dbMgr.slotThere == true)
        {
            InventorySlots[0].SetActive(true);
            HowManyPotions.text = "X" + dbMgr.PotionsForDisplay.ToString();
            dbMgr.KeepingTrackOfNumbers("SELECT*FROM PlayerInventory");
        }
        else
        {
            InventorySlots[0].SetActive(false);
        }
        
    }
    void CloseOnClick()
    {
        InventoryMenu.SetActive(false);
        Cursor.visible = false;
    }
}
