using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {
	public GameObject Currency;
	public static bool CrystalCollected;
	void OnTriggerEnter2D(Collider2D collider){
		Currency.SetActive(false);
		CrystalCounter.ThirdDiget++;
		ShopTable.amountOfPlayerCurrency++;
	}
}
