using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleClickEvent : MonoBehaviour {
	
	public SpriteRenderer ButtonRenderer;
	void OnMouseEnter(){
	ButtonRenderer.color = Color.gray;
	}
	void OnMouseExit(){
		ButtonRenderer.color = Color.white;
	}
	
}	
