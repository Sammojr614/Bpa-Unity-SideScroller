using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Continue : MonoBehaviour
{
    //ContinueButton
    [SerializeField] private Button continueButton;

    //Will replace this later with the database
    private string previousLevel = "Ozul's Dream";

    public static bool resetLives = false;

    //Required for the button to work
    void Start()
    {
        continueButton.onClick.AddListener(onClick);
    }

    //If the player presses continue, they will return to the previous level
    void onClick()
    {
        SceneManager.LoadScene(previousLevel);
        resetLives = true;
    }
}
