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
        afterBuy = PlayerCrystals - priceOfPotion;
        if (Input.GetButtonDown("Shop"))
        {
            ShopMenu.SetActive(true);
            Cursor.visible = true;
        }
    }
    void CloseOnClick()
    {
       
        ShopMenu.SetActive(false);
        Cursor.visible = false;
    }
    void BuyOnClick()
    {
        string insertThis = string.Format("UPDATE PlayerSaveData SET PlayerCurrency='{0}'", afterBuy);
        if (PlayerCrystals >= priceOfPotion)
        {
            PlayerCrystals = afterBuy;
            dataMgr.normalDbCommand(insertThis);
        }
        else
        {
            ButtonText.text = "Can't Afford";
        }
    }
}
