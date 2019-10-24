using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathPlain : MonoBehaviour {
void OnTriggerEnter(){
	if(CompareTag("Player")){
		PlayerHealth.health = 0;
	}
}
}


