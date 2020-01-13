using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

	public static bool gamePaused = false;
    public GameObject pauseMenu;
    public GameObject resumeButton;
    public GameObject quitButton;
    public GameObject ShopButton;
    public static bool resume;
   
    private void Start()
    {
        pauseMenu.SetActive(false);
        resumeButton.SetActive(false);
        quitButton.SetActive(false);
        ShopButton.SetActive(false);
    }


    void Update () {
        if (Input.GetButtonDown("Cancel")) {
            if (PauseGame.isGamePaused == true)
            {
                ResumeGame();
            }
            else if (PauseGame.isGamePaused == false)
            {
                PausedGame();
            }
        }
    }

    public void PausedGame()
    {
        Time.timeScale = 0;
        gamePaused = true;
        PauseGame.isGamePaused = gamePaused;
        Cursor.visible = true;
        pauseMenu.SetActive(true);
        resumeButton.SetActive(true);
        quitButton.SetActive(true);
        ShopButton.SetActive(true);
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        resumeButton.SetActive(false);
        quitButton.SetActive(false);
        ShopButton.SetActive(false);
        Cursor.visible = false;
        gamePaused = false;
        PauseGame.isGamePaused = gamePaused;
        Time.timeScale = 1;
    }
}
