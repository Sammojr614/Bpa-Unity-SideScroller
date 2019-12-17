using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyKnifeUpgrade : MonoBehaviour {
    public int Price;
    public GameObject NotenoughCrystals;
    public GameObject PriceDisplay;

void Start(){
    NotenoughCrystals.SetActive(false);
}
void OnMouseDown(){
    if(Input.GetMouseButtonDown(0)){
        if(ShopTable.amountOfPlayerCurrency >= Price){
            LoadData.PlayerHaveKnifeUpgrade = true;
            int newCurrency = ShopTable.amountOfPlayerCurrency - Price;
            ShopTable.amountOfPlayerCurrency = newCurrency;
            int newDidget = CrystalCounter.ThirdDiget - Price;
            CrystalCounter.ThirdDiget = newDidget;
        }
    }
}
void OnMouseEnter(){
    PriceDisplay.SetActive(true);
    if(ShopTable.amountOfPlayerCurrency < Price){
        NotenoughCrystals.SetActive(true);
    }
}
void OnMouseExit(){
    PriceDisplay.SetActive(false);
    NotenoughCrystals.SetActive(false);
}
}
