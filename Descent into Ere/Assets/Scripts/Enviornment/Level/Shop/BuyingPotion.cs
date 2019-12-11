using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BuyingPotion : MonoBehaviour {
	public int CostOfItem;
	public GameObject Price;
	DbManager dataManager = DbManager.Instance;
	void Start(){
		Price.SetActive (false);
	}

void OnMouseDown(){
	if(Input.GetMouseButtonDown(0) && BuyingStuff.NotEnoughMoney == false){
		//Player Currency
		int newPlayerCurrency = ShopTable.amountOfPlayerCurrency - CostOfItem;
		ShopTable.amountOfPlayerCurrency =  newPlayerCurrency;
		//Counter 
		int newCounterValue = CrystalCounter.ThirdDiget - CostOfItem;
		CrystalCounter.ThirdDiget = newCounterValue;
		Inventory.NumberOfPotions++;
		Inventory.NumberOfItems++;
		ShopTable.NumberOfItems--;
		dataManager.normalDbCommand("UPDATE ShopStock SET amountOfItem='"+ Convert.ToInt32(ShopTable.NumberOfItems) + "'");
	}
}
	void OnMouseEnter(){
		Price.SetActive (true);
	}
	void OnMouseExit(){
		Price.SetActive (false);
	}
}
