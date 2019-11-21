using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopTable : MonoBehaviour {
	public static int amountOfPlayerCurrency;
	public static bool ShopContainsPotion;
	void Start () {	
	List<ShopItemsList> ShopStock = new List<ShopItemsList>();
	/* Potion Item in the Shop Stock */
	ShopItemsList PotionStock = new ShopItemsList("Potion", 1, 3);
	ShopStock.Add(PotionStock);
	ShopContainsPotion = true;
	if(ShopStock.Contains(PotionStock)){
		ShopContainsPotion = true;
	}else{
		ShopContainsPotion = false;
	}
	
	}
	class ShopItemsList{
		DbManager DbManager = DbManager.Instance;
		public string nameOfItem{get; set;}
		public int costOfItem{get; set;}
		public int numberOfItem{get; set;}
		public string insertThis;
		public ShopItemsList(string NameOfItem, int CostOfItem, int NumberofItem){
			nameOfItem = NameOfItem;
			costOfItem = CostOfItem;
			numberOfItem = NumberofItem;
			if(ShopContainsPotion == true){
				insertThis = string.Format("INSERT INTO ShopStock(Items, NumberOfItems, CostOfItem) VALUES({0},{1},{2})",NameOfItem, NumberofItem, CostOfItem);
				DbManager.dbCommand(DbManager.connectionString, insertThis);
			}else{

			}
		}
	}
	
}
