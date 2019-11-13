using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sign : MonoBehaviour {
	public GameObject TextBox;
	public static bool playerInBox;
	void Start(){
		TextBox.SetActive(false);
	}
void OnTriggerEnter2D(Collider2D collider){
	playerInBox = true;
	TextBox.SetActive(true);


}
void OnTriggerStay2D(Collider2D collider){
	playerInBox = true;
	TextBox.SetActive(true);
}
void OnTriggerExit2D(Collider2D collider){
	TextBox.SetActive(false);
		playerInBox = false;

}
}
