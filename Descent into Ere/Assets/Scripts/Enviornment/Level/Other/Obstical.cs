using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstical : MonoBehaviour {
public GameObject ObsitcalGameObject;
	void OnTriggerEnter2D(Collider2D collision){
		
		if(collision.CompareTag("Player") && Inventory.haveKey == true){
		DestroyObject(ObsitcalGameObject);
		Inventory.haveKey = false;
		}
	}
}
