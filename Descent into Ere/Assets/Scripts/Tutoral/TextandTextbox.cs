using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class TextandTextbox : MonoBehaviour {
	public GameObject[] letters;

	public int indexnumber;
	void Update(){
		if (Sign.playerInBox == true) {
			//Supposed to Enable the Object if Player In box is True
			foreach (GameObject letter in  letters) {
				int IndexLength = letters.Length;
				for (indexnumber = 0; indexnumber < IndexLength; indexnumber++) {
					
					letters [indexnumber].SetActive (true);
				}
			}
		} else if (Sign.playerInBox == false) {
			//Supposed to Disable The Object if player in box is false
			foreach (GameObject letter in letters) {
				int IndexLength = letters.Length;
				for (indexnumber = 0; indexnumber < IndexLength; indexnumber++) {
					letters [indexnumber].SetActive (false);
				}
			}
		}
	}

}
