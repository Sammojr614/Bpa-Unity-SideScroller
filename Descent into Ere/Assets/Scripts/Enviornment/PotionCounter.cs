using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionCounter : MonoBehaviour {
	
	public GameObject ThreePotions;
	public GameObject TwoPotions;
	public GameObject OnePotion;
	public List<GameObject> potions;

	private List<GameObject> getPotionsList() {
		if (potions == null) {
			potions = new List<GameObject>();
			potions.Add (OnePotion);
			potions.Add (TwoPotions);
			potions.Add (ThreePotions);
		}

		return potions;
	}
	
	// Update is called once per frame
	void Update () {
		// set each to false
		List<GameObject> potions = getPotionsList();

		potions.ForEach ((obj) => obj.SetActive (false));
	 
		if (Inventory.NumberOfPotions > 0 && Inventory.NumberOfPotions <= potions.Count) {
			potions [Inventory.NumberOfPotions - 1].SetActive (true);
		}

//		if (Inventory.NumberOfPotions == 3) {
//			ThreePotions.SetActive (true);
//			TwoPotions.SetActive (false);
//			OnePotion.SetActive (false);
//		} else if (Inventory.NumberOfPotions == 2) {
//			ThreePotions.SetActive (false);
//			TwoPotions.SetActive (true);
//			OnePotion.SetActive (false);
//		} else if (Inventory.NumberOfPotions == 1) {
//			ThreePotions.SetActive (false);
//			TwoPotions.SetActive (false);
//			OnePotion.SetActive (true);
//		} else if (Inventory.NumberOfPotions == 0) {
//			ThreePotions.SetActive (false);
//			TwoPotions.SetActive (false);
//			OnePotion.SetActive (false);
//		}
	}
			
		

}
