using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginGame : MonoBehaviour {
	SpriteRenderer BeginGameSprite;
	GameObject TitleStuff;
	
	void Start () {
		BeginGameSprite = gameObject.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		BeginGameSprite.enabled = false;
			if(StartClickSensor.clicked == true){
				BeginGameSprite.enabled = true;
			}
			if(Input.GetMouseButtonDown(0) &&  Input.mousePosition == BeginGameSprite.transform.position){
				SceneManager.LoadScene("MainHub");
			}
		}
}

