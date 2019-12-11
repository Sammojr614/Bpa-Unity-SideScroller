using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyingStuff : MonoBehaviour {
	public GameObject[] VisibleShop;
	public GameObject SoldOutSign;
	public static int NumberOfItemsTotal;
	public static bool SoldOut;
	public static bool NotEnoughMoney;
	DbManager dataManager = DbManager.Instance;
	void Start(){
		Cursor.visible = true;
	}
	void Update(){
		dataManager.refeshShop("SELECT*FROM ShopStock");
	if(ShopTable.NumberOfItems >= 0){
		VisibleShop[0].SetActive(true);
		SoldOut = false;
		SoldOutSign.SetActive(false);
	}else if(ShopTable.NumberOfItems < 1){
		SoldOut = true;
		SoldOutSign.SetActive(true);

	}
	if(ShopTable.amountOfPlayerCurrency < ShopTable.CostOfItem){
		NotEnoughMoney = true;
	}else if(ShopTable.amountOfPlayerCurrency >= ShopTable.CostOfItem){
		NotEnoughMoney =false;
	}
	}
}
