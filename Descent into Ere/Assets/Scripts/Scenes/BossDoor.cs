using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossDoor : MonoBehaviour {
public GameObject BossDoorOpen;
	void OnTriggerStay2D(Collider2D collision){
		if (collision.CompareTag ("Player")) {
			if (Input.GetButton ("EnterDoor") && Inventory.haveBossKey == true) {
				SceneManager.LoadScene ("PlayerDreamPt2");
				Inventory.haveBossKey = false;
				if (Inventory.NumberOfItems < 0) {
					Inventory.NumberOfItems--;
				}
			}
		}
	}

}
