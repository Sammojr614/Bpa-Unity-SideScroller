using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour {

    // Switch player presses
    public GameObject Switch;
    //Darkness in the level
    public GameObject Darkness;
    //Outlines for the platforms
    public GameObject PlatformOutline;
    public GameObject PlatformOutline1;
	
    /* When the player enters the trigger
     * of the switch, the switch disapears
     * and the darkness is destroyed
     */
	void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Switch.SetActive(false);
            DestroyObject(Darkness);
            DestroyObject(PlatformOutline);
            DestroyObject(PlatformOutline1);
        }
    }
}
