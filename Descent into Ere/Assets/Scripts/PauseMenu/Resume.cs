using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resume : MonoBehaviour {

    public static bool gameResumed;
    SpriteRenderer ResumeButton;
void Start(){
    ResumeButton = gameObject.GetComponent<SpriteRenderer>();
}
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
