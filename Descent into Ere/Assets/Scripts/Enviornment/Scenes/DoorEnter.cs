using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DoorEnter : MonoBehaviour {

    /* Value used to switch to desired scene
     * Serialized so it can be accessed outside of the script
     * While still being a private variable
     */
    [SerializeField] private string newLevel;


    //Determines if door is locked or not
    public static bool DoorLocked = false;

    //Method for when the player enters the trigger
    void OnTriggerEnter2D(Collider2D other)
    {
        /* Checks to see that the player 
         * has collided with the trigger
         */
        if (other.CompareTag("Player"))
        {
            /* If the player presses the EnterDoor button
             * (W or Up Arrow), and the door is unlocked,
             * After collision with the trigger
             * It will load the desired scene
             */            
            if (Input.GetButtonDown("EnterDoor") && DoorLocked == false)
            {
                SceneManager.LoadScene(newLevel);
            }
        }
    }

    //Method for while the player is in the trigger
    void OnTriggerStay2D(Collider2D other)
    {
        /* Checks to see that the player
         * is colliding with the trigger
         */
        if (other.CompareTag("Player"))
        {
            /* If the player presses the EnterDoor button,
             * And the door is unlocked
             * While colliding with the trigger
             * It will load the desired scene
             */            
            if (Input.GetButtonDown("EnterDoor") && DoorLocked == false)
            {
                SceneManager.LoadScene(newLevel);
            }
        }
    }


}

