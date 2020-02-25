using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UseInventoryItem : MonoBehaviour
{
    public Button UseButton;
    public Text ButtonText;
    DbManager dbMgr = DbManager.Instance;
    private void Start()
    {
        //Use Button Call
        UseButton.onClick.AddListener(UseOnClick);
    }
    private void Update()
    {
        //If you Have No Potions the UseButton Doesn't Work
        if(Inventory.NumberOfPotions == 0)
        {
            UseButton.enabled = false;
        }
        else
        {
            UseButton.enabled = true;
        }
    }
        /*Use Button Function*/
    void UseOnClick()
    {
        if(Inventory.NumberOfPotions != 0 && Health.health != 4)
        {
            ButtonText.text = "Use";
            UseButton.enabled = true;
            Inventory.NumberOfPotions--;
            string insertThis = string.Format("UPDATE PlayerInventory SET NumberOfItem = '{0}'", Inventory.NumberOfPotions);
            Health.health = Health.health + 1;
            dbMgr.normalDbCommand(insertThis);

        }
        //if you have Full health, You can't use the Potions
        else
        {
            ButtonText.text = "Full Health";
            UseButton.enabled = false;
        }
    }
}
