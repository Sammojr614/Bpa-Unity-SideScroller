using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour {
	
	public SpriteRenderer PlayerRenderer;
	Transform PlayerTrans;
	void Start(){
		PlayerTrans = gameObject.GetComponent<Transform>();
	}
	void Update () {
		if(Input.GetButton("MoveLeft")){
			PlayerRenderer.flipX = true;
		}else if(Input.GetButton("MoveRight")){
			PlayerRenderer.flipX = false;
		}
	}
}
