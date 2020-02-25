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
        UseButton.onClick.AddListener(UseOnClick);
    }
    private void Update()
    {
        if(Inventory.NumberOfPotions == 0)
        {
            UseButton.enabled = false;
        }
        else
        {
            UseButton.enabled = true;
        }
    }
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
        else
        {
            ButtonText.text = "Full Health";
            UseButton.enabled = false;
        }
    }
}
