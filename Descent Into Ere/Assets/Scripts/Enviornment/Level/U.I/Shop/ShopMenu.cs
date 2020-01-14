using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMenu : MonoBehaviour
{
    public GameObject ShopMenuGameObject;
    public GameObject[] ShopTable;
    DbManager dataManager = DbManager.Instance;
   
    void Start(){
        ShopMenuGameObject.SetActive(false);
      dataManager.getShopStockFromDb("SELECT*FROM ShopStock");
    }
    void Update(){
        if(BuyingStuff.NumberOfItems == 0){
            ShopTable[1].SetActive(false);
        }
    }
}
