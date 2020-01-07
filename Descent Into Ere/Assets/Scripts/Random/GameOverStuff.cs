using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverStuff : MonoBehaviour
{
    public GameObject ContinueButton;
    public GameObject QuitButton;
    void Start()
    {
        ContinueButton.SetActive(false);
        QuitButton.SetActive(false);
    }
    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ContinueButton.SetActive(true);
            QuitButton.SetActive(true);
        }
    }
}
