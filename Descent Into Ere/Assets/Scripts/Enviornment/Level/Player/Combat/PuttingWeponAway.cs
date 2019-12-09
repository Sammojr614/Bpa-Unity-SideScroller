using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingWeponAway : MonoBehaviour {

public GameObject ButterKnife;
	void Start () {
		ButterKnife.SetActive(true);
	}
	
	
	void Update () {
		if(Input.GetKey(KeyCode.F)){
			ButterKnife.SetActive(false);
		}
	}
}
