using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipSprites : MonoBehaviour {
 SpriteRenderer Player;
	// Use this for initialization
	void Start () {
		Player = gameObject.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("MoveLeft")){
			Player.flipY = true;
		}else{
			if(Input.GetButtonDown("MoveRight")){
				Player.flipY = false;
			}
		}
	}
}
