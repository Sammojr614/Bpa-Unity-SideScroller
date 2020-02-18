using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public static int PlayerCrystals;
    DbManager dataMgr = DbManager.Instance;
    public Button BuyButton;
    int priceOfPotion = 5;
    public GameObject ShopMenu;
    public Button CloseButton;
    public Text ButtonText;
    int afterBuy;
    // Start is called before the first frame update
    void Start()
    {
        ShopMenu.SetActive(false);
        CloseButton.onClick.AddListener(CloseOnClick);
        BuyButton.onClick.AddListener(BuyOnClick);
       
    }

    // Update is called once per frame
    void Update()
    {
        dataMgr.CheckInventory("SELECT*FROM PlayerInventory");
        if(dataMgr.slotThere == false)
        {
            dataMgr.normalDbCommand("INSERT INTO PlayerInventory(SlotNumber, ItemInSlot, NumberOfItemInSlot) VALUES('1','Potion',")
        }
        
    }
    void CloseOnClick()
    {
        ShopMenu.SetActive(false);
    }
    void BuyOnClick()
    {
        if(PlayerCrystals >= priceOfPotion && Inventory.NumberOfPotions >= 3)
        {
            afterBuy = PlayerCrystals - priceOfPotion;
            PlayerCrystals = afterBuy;
            string insertThis = string.Format("UPDATE PlayerInventory SET NumberOfItemsInSlot = '{0}'", PlayerCrystals);
            dataMgr.normalDbCommand(insertThis);

        }
    }
}
