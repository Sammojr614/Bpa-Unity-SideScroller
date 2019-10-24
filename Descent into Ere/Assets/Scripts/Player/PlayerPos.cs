using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerPos : MonoBehaviour {
 Transform PlayerTrans;
 public static float SpawnPointX;
 public static float SpawnPointY;
 public static float SpawnPointZ;
	void Start () {
		PlayerTrans = gameObject.GetComponent<Transform>();
		SpawnPointX = PlayerTrans.position.x;
		SpawnPointY = PlayerTrans.position.y;
		SpawnPointZ = PlayerTrans.position.z;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(PlayerHealth.health == 0){
			PlayerTrans.transform.position.Set(SpawnPointX,SpawnPointY, SpawnPointZ);
		}
	}


}
