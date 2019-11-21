using System;
using System.Collections.Generic;
using UnityEngine;

public class ShopScript:MonoBehaviour{
	
}
class WhatsInStore:ShopScript{
	//making a list from this
	public string ItemName{ get; set; }
	public int ItemPrice{ get; set; }
	public int NumberOfItem{ get; set;}
	public bool cannotBuyItem;
	public int NewCrystalAmount;
	public WhatsInStore(string itemname, int itemprice, int numberofitem){
		ItemName = itemname;
		ItemPrice = itemprice;
		NumberOfItem = numberofitem;
		if (ShopTable.amountOfPlayerCurrency < itemprice) {
			cannotBuyItem = true;
		} else if (ShopTable.amountOfPlayerCurrency >= itemprice) {
			cannotBuyItem = false;
			NewCrystalAmount = ShopTable.amountOfPlayerCurrency - itemprice;

		}
	}
}
