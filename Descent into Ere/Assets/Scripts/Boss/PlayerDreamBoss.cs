using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDreamBoss : MonoBehaviour {

	public static int BossHealth;
	public GameObject Boss;
	public GameObject Bottle;
	public GameObject LevelComplete;
	public GameObject LevelExitDoor;
	void Start () {
		BossHealth = 20;
		Boss.SetActive(false);
	}
	void Update(){
		if(PlayerDreamBossBottle.BeginBoss == true){
			Boss.SetActive(true);
			Bottle.SetActive(false);
		}
		if(BossHealth > 0){
			LevelComplete.SetActive(false);
			LevelExitDoor.SetActive(false);
		}else{
			LevelComplete.SetActive(true);
			LevelExitDoor.SetActive(true);
		}
		if(BossHealth == 0){
			Boss.SetActive(false);
		}
	}
}
