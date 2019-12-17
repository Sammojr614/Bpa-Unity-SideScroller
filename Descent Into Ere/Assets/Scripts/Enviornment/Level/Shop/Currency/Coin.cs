using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Coin : MonoBehaviour {
	public GameObject Currency;
	public static bool CrystalCollected;
	DbManager dataManager = DbManager.Instance;
	void OnTriggerEnter2D(Collider2D collider){
		Currency.SetActive(false);
		CrystalCounter.ThirdDiget++;
		ShopTable.amountOfPlayerCurrency++;
		dataManager.normalDbCommand("UPDATE PlayerSaveData SET PlayerCurrency='" + Convert.ToInt32(ShopTable.amountOfPlayerCurrency) + "'");
		
	}
}
