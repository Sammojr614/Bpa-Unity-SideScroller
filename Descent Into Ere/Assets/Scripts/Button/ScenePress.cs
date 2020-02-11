using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScenePress : MonoBehaviour
{
    public Button ButtonPressed;
    public string SceneName;
    void Start()
    {
        ButtonPressed.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick(){
        SceneManager.LoadScene(SceneName);
    }

   
}
