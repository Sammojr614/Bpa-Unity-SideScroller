using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class TextandTextbox : MonoBehaviour {
	public GameObject[] letters;
	void Update(){
		if(Sign.playerInBox == true){
			foreach(var indexNumber in letters){
				int IndexValue;
				for(IndexValue = 0; IndexValue < Convert.ToInt32(indexNumber)-1; IndexValue++){
					letters[IndexValue].SetActive(true);
				}
			}
	}
	}

}
