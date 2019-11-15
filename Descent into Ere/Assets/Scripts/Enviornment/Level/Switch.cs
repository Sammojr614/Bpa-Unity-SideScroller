using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {

    //Trapdoor in the level
    public GameObject TrapDoor;
    //The button the player presses
    public GameObject Button;
    //The floor below the button
    public GameObject Floor;

    /* When the player enters the trigger
     * of the button switch, and it is pressed
     * the button will disapear, and both the trap door
     * and floor below the button are destroyed
     */
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Button.SetActive(false);
            DestroyObject(TrapDoor);
            DestroyObject(Floor);
        }
    }
}
