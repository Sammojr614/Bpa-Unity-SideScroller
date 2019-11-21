using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {
	public GameObject Currency;
	void OnTriggerEnter2D(Collider2D collider){
		Currency.SetActive(false);
		ShopTable.amountOfPlayerCurrency ++;
	}
}
