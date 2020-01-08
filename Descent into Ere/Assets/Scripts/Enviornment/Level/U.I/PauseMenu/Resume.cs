using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resume : MonoBehaviour {

    /* Public Boolean used to determine if the 
     * Game is paused in the PauseGame Script
     */
    public static bool gameResumed;

    public GameObject resume;

    //Method checks when resume is clicked
    void OnMouseDown () {
       
        /* If the mouse is clicked on resume
         * it will set gameResumed to true
         * Which unpauses the game in the
         * PauseGame script
         */
        if(Input.GetMouseButtonDown(0)){
            resume.GetComponent<PauseMenu>().ResumeGame();
        }else{
            if(PauseGame.isGamePaused == false){
                gameResumed = false;
            }
        }
	}
}
