using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipSprites : MonoBehaviour {
	Transform PlayerTrans;
	void Start(){
		PlayerTrans = gameObject.GetComponent<Transform>();
	}
	void Update(){
		if(Input.GetButton("MoveLeft")){
		
		
		}else{
			if(Input.GetButton("MoveRight")){
			
			}
		}
	}
}
