using System.Collections;
using System.Collections.Generic;
using UnityEngine;
                /* Main Save Data Singleton*/
public class DataMgr
{
    private static DataMgr getData;
    private DataMgr()
    {

    }
    public static DataMgr Instance
    {
        get
        {
            if(getData == null)
            {
                getData = new DataMgr();
            }
            return getData;
        }
    }
    public int TimesPlayed;
    public string location;
    public int Playerhealth;
    public int PlayerLives;
    public int Playercurrency;
   

}
                    /*Inventory Singleton*/
public class InventoryMgr
{
    private static InventoryMgr inven;
    private InventoryMgr()
    {

    }
    public static InventoryMgr Instance
    {
        get
        {
            if(inven == null)
            {
                inven = new InventoryMgr();
            }
            return inven;
        }
    }
    public string ItemName;
    public int NumberOfItem;
}
                    /*Shop Singleton*/
public class ShopMgr
{
    private static ShopMgr Shoppe;
    private ShopMgr()
    {

    }
    public static ShopMgr Instance
    {
        get
        {
            if(Shoppe == null)
            {
                Shoppe = new ShopMgr();
            }
            return Shoppe;
        }
    }
    public int PriceofItem;
    public string NameOfItem;
}
