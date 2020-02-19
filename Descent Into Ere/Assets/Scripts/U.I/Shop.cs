using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
                                            /*Zach!, DON'T Interpolate My SQLite!*/
    public static int PlayerCrystals;
    DbManager dataMgr = DbManager.Instance;
    public Button BuyButton;
    int priceOfPotion = 5;
    public GameObject ShopMenu;
    public Button CloseButton;
    public Text ButtonText;
    int afterBuy;
    private void Start()
    {
        ShopMenu.SetActive(false);
        dataMgr.CheckInventory("SELECT*FROM PlayerInventory WHERE SlotNumber = '1'");
        if(dataMgr.slotThere == false)
        {
            dataMgr.normalDbCommand("INSERT INTO PlayerInventory(SlotNumber, ItemInSlot, NumberOfItem) VALUES('1','Potion','1')");
        }
        CloseButton.onClick.AddListener(CloseOnClick);
        BuyButton.onClick.AddListener(BuyOnClick);
    }
    private void Update()
    {
        if (Input.GetButtonDown("Shop"))
        {
            ShopMenu.SetActive(true);
            Cursor.visible = true;
        }
    }
    void BuyOnClick()
    {
        if(PlayerCrystals >= priceOfPotion && Inventory.NumberOfPotions <= 3)
        {
            afterBuy = PlayerCrystals - priceOfPotion;
            string newPlayerCurrecny = string.Format("UPDATE PlayerSaveData SET PlayerCurrency = '{0}'", afterBuy);
            dataMgr.normalDbCommand(newPlayerCurrecny);
            Inventory.NumberOfPotions++;
            Inventory.NumberOfItems++;
            string morePotions = string.Format("UPDATE PlayerInventory SET NumberOfItem = '{0}'", Inventory.NumberOfPotions);
            dataMgr.normalDbCommand(morePotions);
        }
    }
    void CloseOnClick()
    {
        ShopMenu.SetActive(false);
        Cursor.visible = false;
    }
}
