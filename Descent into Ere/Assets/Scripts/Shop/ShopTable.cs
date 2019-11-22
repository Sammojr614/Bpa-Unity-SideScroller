using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopTable : MonoBehaviour {
	DbManager dataManager = DbManager.Instance;
	public static int amountOfPlayerCurrency;
	public static bool ShopContainsPotion;
	public static string NameOfItem;
	public static int CostOfItem;
	public static int NumberOfItems;

	void Start(){
		dataManager.getShopStockFromDb ("SELECT*FROM ShopStock");
	}
	
}
