using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathPlain : MonoBehaviour {
	public string sceneName;
	DbManager dataManager = DbManager.Instance;
	
void OnTriggerEnter2D(Collider2D collsion){
	if(collsion.CompareTag("Player")){
		PlayerLives.Lives--;
	}
}
void OnTriggerExit2D(Collider2D collsion){
	if(collsion.CompareTag("Player")){
		SceneManager.LoadScene(sceneName);
	}
}
}


