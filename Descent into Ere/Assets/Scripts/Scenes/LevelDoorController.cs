using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDoorController : MonoBehaviour {

	public GameObject PlayerDreamDoor;
	public GameObject LucidDoor;
	Collider2D LucidDoorCollider;
	Collider2D PlayerDreamDoorCollider;
	public static bool LucidLocked = true;
	void Start () {
		LucidDoorCollider = gameObject.GetComponent<BoxCollider2D>();
		PlayerDreamDoorCollider = gameObject.GetComponent<BoxCollider2D>();
		if(LucidLocked == true){
			LucidDoorCollider.enabled = false;
		}else{
			if(LucidLocked == false){
				LucidDoorCollider.enabled = true;
			}
		}
	}
}
