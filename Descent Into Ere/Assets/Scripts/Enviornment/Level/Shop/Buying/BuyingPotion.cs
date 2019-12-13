using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BuyingPotion : MonoBehaviour {
	public int CostOfItem;
	public GameObject Price;
	public GameObject NotenoughMoney;
	DbManager dataManager = DbManager.Instance;
	void Start(){
		Price.SetActive(false);
		NotenoughMoney.SetActive(false);
	}
	void OnMouseDown(){
		if(Input.GetMouseButtonDown(0)){
			if(ShopTable.amountOfPlayerCurrency >= CostOfItem){
				int newCurrency = ShopTable.amountOfPlayerCurrency - CostOfItem;
				int newCounter = CrystalCounter.ThirdDiget - CostOfItem;
				if(newCurrency > CostOfItem){
					dataManager.normalDbCommand("UPDATE PlayerSaveData SET PlayerCurrency='" + Convert.ToInt32(newCurrency) + "'");
				}
				if(newCounter > CostOfItem){
					dataManager.normalDbCommand("UPDATE Money SET ThirDidget='"+ Convert.ToInt32(newCounter) + "'");
				}
			}
		}
	}
	void OnMouseEnter(){
		Price.SetActive(true);
		if(ShopTable.CostOfItem < CostOfItem){
			NotenoughMoney.SetActive(true);
		}
	}
	void OnMouseExit(){
		Price.SetActive(false);
		NotenoughMoney.SetActive(false);
	}
}
