using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutoralWallCheck : MonoBehaviour {
	public GameObject Wall;
	public static int TimesPlayed;
	void Start(){
		if(TimesPlayed >= 1){
			Wall.SetActive(false);
		}else if(TimesPlayed == 0){
			Wall.SetActive(true);
		}
	}
	void OnTriggerEnter2D(Collider2D collider){
		if(collider.CompareTag("Player") && Inventory.haveKey == true){
			Debug.Log (TimesPlayed);
			TimesPlayed++;
			Debug.Log (TimesPlayed);
			Wall.SetActive(false);
			Inventory.haveKey = false;
			Inventory.NumberOfItems--;

		}
	}
}
