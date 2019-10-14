using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resume : MonoBehaviour {

    public static bool gameResumed;
	void Update () {
       
        if(Input.GetMouseButtonDown(0)){
            gameResumed = true;
        }else{
            if(PauseGame.isGamePaused == false){
                gameResumed = false;
            }
        }
	}
}
