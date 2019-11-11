using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sign : MonoBehaviour {
	public GameObject TurtoralText;
	public static bool playerInBox;
	void Start(){
		TurtoralText.SetActive(false);
	}
void OnTriggerEnter2D(Collider2D collider){
	playerInBox = true;
	TurtoralText.SetActive(true);


}
void OnTriggerStay2D(Collider2D collider){
	playerInBox = true;
}
void OnTriggerExit2D(Collider2D collider){
	TurtoralText.SetActive(false);
		playerInBox = false;

}
}
