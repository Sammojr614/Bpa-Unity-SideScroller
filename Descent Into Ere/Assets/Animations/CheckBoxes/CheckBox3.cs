using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBox3 : MonoBehaviour {
	public GameObject Check;
	public GameObject EmptyCheck;

	void Update(){
		if(LevelCompletion.LevelComplete == 3){
			Check.SetActive(true);
			EmptyCheck.SetActive(false);
		}else{
			Check.SetActive(false);
			EmptyCheck.SetActive(true);
		}
	}
}
