using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrades : MonoBehaviour {
	public GameObject[] Upgrade;
	public static bool PlayerHasKnifeUpgrade;
	// Use this for initialization
	void Start () {
		if(PlayerHasKnifeUpgrade == true){
			Upgrade[0].SetActive(false);
		}else{
			Upgrade[0].SetActive(true);
		}
	}	
}
