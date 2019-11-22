using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyingStuff : MonoBehaviour {
	public GameObject[] VisibleShop;
	DbManager dataManager = DbManager.Instance;
	void OnMouseButtonDown(){
		if (Input.GetMouseButtonDown (0)) {
			if (ShopTable.amountOfPlayerCurrency >= dataManager.CostofItem){
				int NewCurrencyValue = ShopTable.amountOfPlayerCurrency - dataManager.CostofItem;
				ShopTable.amountOfPlayerCurrency = NewCurrencyValue;
				dataManager.NumberOfItem--;
		}
	}
}
	void Update(){
		if (dataManager.NumberOfItem == 0) {
			VisibleShop [0].SetActive (false);
		} else {
			VisibleShop [0].SetActive (true);
		}
	}
}
