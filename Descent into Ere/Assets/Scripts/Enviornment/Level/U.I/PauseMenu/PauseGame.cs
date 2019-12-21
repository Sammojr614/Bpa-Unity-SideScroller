using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour {

    public bool gamePaused = false;
    public GameObject pauseMenu;
    public GameObject resumeButton;
    public GameObject quitButton;
    public static bool isGamePaused;
    private void Start()
    {
        pauseMenu.SetActive(false);
        resumeButton.SetActive(false);
        quitButton.SetActive(false);
    }


    void Update () {
        if (Input.GetButtonDown("Cancel")) {
            if (isGamePaused == true)
            {
                ResumeGame();
            }
            else if (isGamePaused == false)
            {
                PausedGame();
            }

        }
    }

    public void PausedGame()
    {
        Time.timeScale = 0;
        gamePaused = true;
        isGamePaused = gamePaused;
        Cursor.visible = true;
        pauseMenu.SetActive(true);
        resumeButton.SetActive(true);
        quitButton.SetActive(true);
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        resumeButton.SetActive(false);
        quitButton.SetActive(false);
        Cursor.visible = false;
        gamePaused = false;
        isGamePaused = gamePaused;
        Time.timeScale = 1;
    }

}
