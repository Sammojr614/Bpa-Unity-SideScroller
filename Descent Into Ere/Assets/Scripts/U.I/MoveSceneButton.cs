using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MoveSceneButton : MonoBehaviour
{
    public Button moveButton;
    public string sceneName;


    private void Start()
    {

        moveButton.onClick.AddListener(moveScene);
        
    }

    private void moveScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
