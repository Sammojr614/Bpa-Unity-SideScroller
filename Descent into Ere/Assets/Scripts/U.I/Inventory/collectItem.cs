using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectItem : MonoBehaviour {
	public GameObject Item;
	void Start(){
		Item.GetComponent<GameObject>();
		Item.SetActive(true);
	}
	
	void OnTriggerEnter2D(Collider2D itemCollider){
		if(itemCollider.CompareTag("Player")){
			Inventory.NumberOfItems++;
			Inventory.NumberOfPotions++;
			if(Inventory.NumberOfPotions > 3){
				Inventory.NumberOfPotions = 3;
			}
			Item.SetActive(false);
            Debug.Log(Inventory.NumberOfItems);
			
		}
	}
}
