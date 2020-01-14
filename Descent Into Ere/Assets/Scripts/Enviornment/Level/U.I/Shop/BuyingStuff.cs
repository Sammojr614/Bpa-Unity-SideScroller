using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyingStuff : MonoBehaviour
{
    public int ItemID;
   public static int PriceOfItem;
   public static int NumberOfItems;
   public GameObject NotEnoughCurrency;
   public Text NumberOfItem;
   DbManager dataManager = DbManager.Instance;
   void Start(){
       string inserthis = string.Format("SELECT*FROM ShopStock WHERE ItemId = {0}", ItemID);
       NotEnoughCurrency.SetActive(false);
       dataManager.getShopStockFromDb(inserthis);
   }
   void Update(){
       NumberOfItem.text = NumberOfItems.ToString();
   }
   void OnMouseDown(){

       if(Input.GetMouseButtonDown(0)){
           if(ShopTable.amountOfPlayerCurrency >= PriceOfItem){
               int newCurrency = ShopTable.amountOfPlayerCurrency - PriceOfItem;
               ShopTable.amountOfPlayerCurrency = newCurrency;
               NumberOfItems--;
               string insertThisToo = string.Format("UPDATE ShopStock WHERE ItemId = {0} SET amountOfItem = {1}", ItemID,NumberOfItems);
               dataManager.setShop(insertThisToo);
           }else if(ShopTable.amountOfPlayerCurrency < PriceOfItem){
               NotEnoughCurrency.SetActive(true);
           }
       }
   }
   void OnMouseUp(){
       if(Input.GetMouseButtonUp(0)){
           NotEnoughCurrency.SetActive(false);
       }
   }
}
