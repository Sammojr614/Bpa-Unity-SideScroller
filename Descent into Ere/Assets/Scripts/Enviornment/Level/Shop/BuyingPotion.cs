using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BuyingPotion : MonoBehaviour {
	public int CostOfItem;
	public GameObject Price;
	void Start(){
		Price.SetActive (false);
	}
	
void OnMouseDown(){
	if(Input.GetMouseButtonDown(0) && BuyingStuff.NotEnoughMoney == false){
		int newPlayerCurrency = ShopTable.amountOfPlayerCurrency - CostOfItem;
		ShopTable.amountOfPlayerCurrency =  newPlayerCurrency;
		int newCounterValue = CrystalCounter.ThirdDiget - CostOfItem;
		CrystalCounter.ThirdDiget = newCounterValue;
		Inventory.NumberOfPotions++;
		Inventory.NumberOfItems++;
		ShopTable.NumberOfItems--;
		Debug.Log(ShopTable.NumberOfItems);
	}
}
	void OnMouseEnter(){
		Price.SetActive (true);
	}
	void OnMouseExit(){
		Price.SetActive (false);
	}
}
