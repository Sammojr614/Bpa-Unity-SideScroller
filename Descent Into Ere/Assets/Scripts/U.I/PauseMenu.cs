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
    // Start is called before the first frame update
    void Start()
    {
        PauseMenuPanel.SetActive(false);
        ResumeButton.onClick.AddListener(ResumeGame);
        QuitButton.onClick.AddListener(QuitGame);
    }

    private void Update()
    {
        if (Input.GetButtonDown("Cancel")){
            PauseGame();
        }
    }
    void PauseGame()
    {
        Time.timeScale = 0;
        Cursor.visible = true;
        PauseMenuPanel.SetActive(true);
    }
    void ResumeGame()
    {
        Time.timeScale = 1;
        Cursor.visible = false;
        PauseMenuPanel.SetActive(false);
    }
    void QuitGame()
    {
        SceneManager.LoadScene("Title");
    }
}
