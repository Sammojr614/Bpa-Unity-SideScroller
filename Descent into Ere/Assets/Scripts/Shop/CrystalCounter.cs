using System;
using UnityEngine;
using System.Collections.Generic;

public class CrystalCounter: MonoBehaviour{
	public GameObject[] FirstDidget;
	public GameObject[] SecondDidget;
	public int FirstDigt;
	public int SecndDigt;
	void Start(){
		if (ShopTable.amountOfPlayerCurrency >= 0) {
			for(var i = 1; i < FirstDidget.Length; i++){
				FirstDidget [i].SetActive (false);
			}
			for (var s = 0; s < SecondDidget.Length; s++) {
				SecondDidget [s].SetActive (false);
			}
		}
	}
	void Update(){
		if (ShopTable.amountOfPlayerCurrency <= 10 && ShopTable.amountOfPlayerCurrency >= 0) {
			FirstDigt = 0;
			FirstDidget [0].SetActive (true);
			SecondDidget [ShopTable.amountOfPlayerCurrency].SetActive (true);
			SecondDidget [ShopTable.amountOfPlayerCurrency - 1].SetActive (false);
		} 
	}	
}