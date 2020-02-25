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
  
    void Start()
    {
        InventoryMenu.SetActive(false);
        CloseButton.onClick.AddListener(CloseOnClick);
    }

    
    void Update()
        
    {
        //This Checks The Db For Inventory Values
        if (Input.GetButtonDown("Inventory"))
        {
            HowManyPotions.text = dbMgr.PotionsForDisplay.ToString();
            InventoryMenu.SetActive(true);
            Cursor.visible = true;
            dbMgr.CheckInventory("SELECT*FROM PlayerInventory");
        }
        //if There is an Item There
        if(dbMgr.slotThere == true)
        {
            InventorySlots[0].SetActive(true);
            HowManyPotions.text = "X" + dbMgr.PotionsForDisplay.ToString();
            dbMgr.KeepingTrackOfNumbers("SELECT*FROM PlayerInventory");
        }
        //if there isn't anything
        else
        {
            InventorySlots[0].SetActive(false);
        }
        
    }
    //For the Close Button
    void CloseOnClick()
    {
        InventoryMenu.SetActive(false);
        Cursor.visible = false;
    }
}
