using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resume : MonoBehaviour {

    /* Public Boolean used to determine if the 
     * Game is paused in the PauseGame Script
     */
    public static bool gameResumed;

    //Method checks when resume is clicked
    void OnMouseDown () {
       
        /* If the mouse is clicked on resume
         * it will set gameResumed to true
         * Which unpauses the game in the
         * PauseGame script
         */
        if(Input.GetMouseButtonDown(0)){
            gameResumed = true;
        }else{
            if(PauseGame.isGamePaused == false){
                gameResumed = false;
            }
        }
	}
}
