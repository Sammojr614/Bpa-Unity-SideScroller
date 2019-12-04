using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using System.IO;
using Mono.Data.Sqlite;
using System;
using UnityEngine.SceneManagement;
public class PlayerLives : MonoBehaviour {

    public static int Lives;
	public Animator livesAnimator;
	
	
	void Update () {
        if(PlayerHealth.health == 0 && Lives > 0){
			Lives--;
			
			PlayerHealth.health += 3;
		}
		if (Lives == 0) {
			SceneManager.LoadScene ("GameOver");
		}
	}
}
