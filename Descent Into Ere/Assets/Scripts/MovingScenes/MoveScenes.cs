using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MoveScenes : MonoBehaviour
{
    public string SceneName;
    public Button MoveSceneButton;
    private void Start()
    {
        MoveSceneButton.onClick.AddListener(OnClickEvent);
    }
    void OnClickEvent()
    {
        SceneManager.LoadScene(SceneName);
    }

}
