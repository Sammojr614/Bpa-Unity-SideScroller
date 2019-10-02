using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScenes2D : MonoBehaviour {

    /* Value used to switch to desired scene
     * Serialized so it can be accessed outside of the script
     * While still being a private variable
     */
    [SerializeField] private string newLevel;

    //Moves scene when player collides with the trigger
    void OnTriggerEnter2D(Collider2D other)
    {
        //Checks to see if the player has the "Player" tag
        if (other.CompareTag("Player"))
        {
            //Loads desired scene
            SceneManager.LoadScene(newLevel);
        }
    }
}
