using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour {

    public Animator health;

    public GameObject potion;

    public void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
			if (PlayerHealth.health < 3) {
				PlayerHealth.Heal (health);
				Inventory.NumberOfItems--;
				Inventory.NumberOfPotions--;
			}
			if (Inventory.NumberOfPotions == 0) {
				potion.SetActive (false);
			}
        }
    }
}
