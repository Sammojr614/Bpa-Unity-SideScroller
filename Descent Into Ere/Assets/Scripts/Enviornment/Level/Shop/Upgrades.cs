using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrades : MonoBehaviour {
	public GameObject[] Upgrade;
	public static bool PlayerHasKnifeUpgrade;
	// Use this for initialization
	void Start () {
		if(LoadData.PlayerHaveKnifeUpgrade == true){
			Upgrade[0].SetActive(false);
		}else if(LoadData.PlayerHaveKnifeUpgrade == false){
			Upgrade[0].SetActive(true);
		}
	}
}
