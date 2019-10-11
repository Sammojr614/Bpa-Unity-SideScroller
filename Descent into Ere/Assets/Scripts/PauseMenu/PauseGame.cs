using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour {

    public bool gamePaused = false;
    public GameObject pauseMenu;
    public static bool isGamePaused;
    private void Start()
    {
        pauseMenu.SetActive(false);
    }


    void Update () {
        if (Input.GetButtonDown("Cancel")) {
            if(gamePaused == false){
                Time.timeScale = 0;
                gamePaused = true;
                isGamePaused = gamePaused;
                Cursor.visible = true;
                pauseMenu.SetActive(true);
            }else{
                pauseMenu.SetActive(false);
                Cursor.visible = false;
                gamePaused = false;
                isGamePaused = gamePaused;
                Time.timeScale = 1;
            }
        }
	}
}
