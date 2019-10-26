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

    public bool DoorLocked;

    //Method for when the player enters the trigger
    void OnTriggerEnter2D(Collider2D other)
    {
        /* Checks to see that the player 
         * has collided with the trigger
         */
        if (other.CompareTag("Player"))
        {
            /* If the player presses the EnterDoor button
             * (W or Up Arrow) after collision with the trigger
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
            /* If the player presses the EnterDoor button
             * While colliding with the trigger
             * It will load the desired scene
             */            
            if (Input.GetButtonDown("EnterDoor") && DoorLocked == false)
            {
                SceneManager.LoadScene(newLevel);
            }
        }
    }

    //Method for while the player has left the trigger
    void OnTriggerExit2D(Collider2D other)
    {

    }

}

