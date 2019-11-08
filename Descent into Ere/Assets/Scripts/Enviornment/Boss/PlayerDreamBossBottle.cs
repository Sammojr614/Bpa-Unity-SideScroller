using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDreamBossBottle : MonoBehaviour {

	public GameObject BossBottle;
	public GameObject Boss;
	public static bool BeginBoss;
	void Start () {
		Boss.SetActive(false);
	}
	void OnTriggerEnter2D(Collider2D collider){
		if(collider.CompareTag("Player")){
			if(Input.GetButton("EnterDoor")){
				BeginBoss = true;
			}
		}
	}
}
