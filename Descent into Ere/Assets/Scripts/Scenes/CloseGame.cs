using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseGame : MonoBehaviour {

    //Activates after a collision trigger
	void OnTriggerEnter2D(Collider2D other)
    {
        //Checks if colliding object is the player
        if (other.CompareTag("Player"))
        {
            //Quits Game
            Application.Quit();
        }
    }
}
