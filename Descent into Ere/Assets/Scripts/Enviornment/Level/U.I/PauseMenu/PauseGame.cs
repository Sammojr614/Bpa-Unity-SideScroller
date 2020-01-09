using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour {

    public static bool isGamePaused;

    void Start()
    {
        isGamePaused = false;
    }
    void Update()
    {

        if (isGamePaused == true || Input.GetButtonDown("Cancel"))
        {

            isGamePaused = false;
        }
    }
}
