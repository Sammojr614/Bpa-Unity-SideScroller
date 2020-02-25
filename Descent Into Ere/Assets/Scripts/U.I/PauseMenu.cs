using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public Button ResumeButton;
    public Button QuitButton;
    public GameObject PauseMenuPanel;
    
    void Start()
    {
        PauseMenuPanel.SetActive(false);
        //The Resume Button Call
        ResumeButton.onClick.AddListener(ResumeGame);
        //Quit Button Call
        QuitButton.onClick.AddListener(QuitGame);
    }

    private void Update()
    {
        if (Input.GetButtonDown("Cancel")){
            //Opening the PauseMenu
            PauseGame();
        }
    }
    //Pausing Game
    void PauseGame()
    {
        Time.timeScale = 0;
        Cursor.visible = true;
        PauseMenuPanel.SetActive(true);
    }
    //Unpausing/ Resuming
    void ResumeGame()
    {
        Time.timeScale = 1;
        Cursor.visible = false;
        PauseMenuPanel.SetActive(false);
    }
    //Quitting
    void QuitGame()
    {
        SceneManager.LoadScene("Title");
    }
}
