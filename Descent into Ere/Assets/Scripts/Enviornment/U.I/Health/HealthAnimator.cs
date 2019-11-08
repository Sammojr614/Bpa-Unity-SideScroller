using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthAnimator : MonoBehaviour {

	public GameObject X1;
	public GameObject X2;
	public GameObject X3;
	
	// Update is called once per frame
	void Update () {
		if (PlayerLives.Lives == 3) {
			X1.SetActive (false);
			X2.SetActive (false);
			X3.SetActive (true);
		} else {
			if (PlayerLives.Lives == 2) {
				X1.SetActive (false);
				X2.SetActive (true);
				X3.SetActive (false);
			} else {
				if (PlayerLives.Lives == 1) {
					X1.SetActive (true);
					X2.SetActive (false);
					X3.SetActive (false);
				} else {
					if (PlayerLives.Lives == 0) {
						X1.SetActive (false);
						X2.SetActive (false);
						X3.SetActive (false);
					}
				}
			}
		}
	}
}
