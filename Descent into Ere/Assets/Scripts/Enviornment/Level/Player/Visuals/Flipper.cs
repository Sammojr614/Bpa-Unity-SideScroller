using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour {
	public SpriteRenderer PlayerRenderer;
	public static bool facingLeft;
	// Update is called once per frame
	void Update () {
		if(Input.GetButton("MoveLeft")){
			PlayerRenderer.flipX = true;
			facingLeft = true;
		}else if(Input.GetButton("MoveRight")){
			PlayerRenderer.flipX = false;
			facingLeft = false;
		}
	}
}
