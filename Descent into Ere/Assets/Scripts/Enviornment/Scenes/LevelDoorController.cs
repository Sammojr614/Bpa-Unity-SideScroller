using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDoorController : MonoBehaviour {


	GameObject LucidDoor;
	Collider2D LucidDoorCollider;
	public static bool LucidLocked = true;
	void Start () {
		LucidDoorCollider = gameObject.GetComponent<BoxCollider2D>();
		//If Lucid Door is Locked
		if(LucidLocked == true){
			LucidDoorCollider.enabled = false;
		}else{
			if(LucidLocked == false){
				LucidDoorCollider.enabled = true;
			}
		}
		

		//How They Lock
	if(LevelCompletion.LevelComplete == 1){
		LucidLocked = false;
	}else{
		LucidLocked = true;
	}
		}
			}
		
	
