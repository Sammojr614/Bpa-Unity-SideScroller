using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossDoor : MonoBehaviour {
public GameObject BossDoorOpen;
	// Use this for initialization
	
	void OnTriggerEnter2D(Collider2D collider){
		if(collider.CompareTag("Player") && Inventory.haveBossKey == true){
			SceneManager.LoadScene("PlayerDreamPt2");
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
