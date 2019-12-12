using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBox3 : MonoBehaviour {
	public GameObject Check;
	GameObject EmptyCheck;
void Start(){
	EmptyCheck = gameObject.GetComponent<GameObject>();
}
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
