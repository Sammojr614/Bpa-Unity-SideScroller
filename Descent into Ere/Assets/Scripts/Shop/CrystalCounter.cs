using System;
using UnityEngine;
using System.Collections.Generic;

public class CrystalCounter: MonoBehaviour{
	public GameObject[] FirstDidget;
	public GameObject[] SecondDidget;
	public static int FirstDigt;
	public static  int SecndDigt;
	public static int ThirdDiget;

	void Start(){
		//Deactivating all The Numbers
		foreach (var firstNumber in FirstDidget) {
			for (var i = 0; i < FirstDidget.Length; i++) {
				FirstDidget [i].SetActive (false);
			}
		}
		foreach (var secondNumber in SecondDidget) {
			for(var i = 0; i < SecondDidget.Length; i++){
				SecondDidget [i].SetActive (false);
			}
		}
	}
	void Update(){
		if (ShopTable.amountOfPlayerCurrency <= 9 && ShopTable.amountOfPlayerCurrency >= 0) {
			ThirdDiget = ShopTable.amountOfPlayerCurrency;
		}
		//Setting the Numbers
		if (ThirdDiget > 9) {
			ThirdDiget = 0;
			SecndDigt++;
		}
		if (SecndDigt > 9) {
			SecndDigt = 0;
			FirstDigt++;
		}
		if (FirstDigt > 9) {
			ThirdDiget = 9;
		}
		//Changing the Numbers Before 10
		if (ThirdDiget < 9 && SecndDigt <= 0) {
			SecondDidget [ThirdDiget].SetActive (true);
			SecondDidget [ThirdDiget -1].SetActive (false);

		} else {
			if (ThirdDiget <= 9 && SecndDigt >= 10) {
				FirstDidget [1].SetActive (true);
				SecondDidget [SecndDigt].SetActive (true);
				SecondDidget [SecndDigt - 1].SetActive (false);
			}
		}
	}
}