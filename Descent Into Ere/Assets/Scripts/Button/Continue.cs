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
    

    public static bool resetLives = false;

    //Required for the button to work
    void Start()
    {
        continueButton.onClick.AddListener(onClick);
    }

    //If the player presses continue, they will return to the previous level
    void onClick()
    {
        

        
        //For Loading the Prev Scene
       
        resetLives = true;
    }
}
