using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionCounter : MonoBehaviour {
	

	public GameObject ThreePotions;
	public GameObject TwoPotions;
	public GameObject OnePotion;

	
	// Update is called once per frame
	void Update () {
		if (Inventory.NumberOfPotions == 3) {
			ThreePotions.SetActive (true);
			TwoPotions.SetActive (false);
			OnePotion.SetActive (false);
		} else {
			if (Inventory.NumberOfPotions == 2) {
				ThreePotions.SetActive (false);
				TwoPotions.SetActive (true);
				OnePotion.SetActive (false);
			} else {
				if (Inventory.NumberOfPotions == 1) {
					ThreePotions.SetActive (false);
					TwoPotions.SetActive (false);
					OnePotion.SetActive (true);
				} else {
					if (Inventory.NumberOfPotions == 0) {
						ThreePotions.SetActive (false);
						TwoPotions.SetActive (false);
						OnePotion.SetActive (false);
					}
				}
			}
		}
	}
}
