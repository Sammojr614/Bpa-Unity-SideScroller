using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginGame : MonoBehaviour {
	SpriteRenderer BeginGameSprite;
	
	void Start () {
		BeginGameSprite = gameObject.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
			if(StartClickSensor.clicked == true){
				BeginGameSprite.enabled = true;
			}else{
				if(StartClickSensor.clicked == false){
					BeginGameSprite.enabled = false;
				}
			}
			if(Input.GetMouseButtonDown(0)){
				SceneManager.LoadScene("MainHub");
			}
	}
}
