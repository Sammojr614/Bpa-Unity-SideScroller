﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{
    public Button QuitButton;
    void Start()
    {
        QuitButton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick(){
        Application.Quit();
    }
}