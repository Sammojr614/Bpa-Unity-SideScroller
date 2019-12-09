using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawingWepon : MonoBehaviour {

	public GameObject ButterKnife;
	void Start () {
		ButterKnife.SetActive(true);
	}
	

	void Update () {
		if(Input.GetKeyDown(KeyCode.F)){
			ButterKnife.SetActive(false);
		}
	}
}
