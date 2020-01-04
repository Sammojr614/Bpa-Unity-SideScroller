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
    //Screenfollow
    public GameObject Screenfollow;
    //Creepy music played in the dark
    public GameObject creepyMusic;
    //Normal music played once the light is on
    public GameObject normalMusic;
	
    /* When the player enters the trigger
     * of the switch, the switch disapears
     * and the darkness is destroyed.
     * Additionally, the platform outlines are
     * destroyed, and the HUD is turned back on,
     * also, the creepy music is turned off,
     * and the normal lucid music plays
     */
	void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Switch.SetActive(false);
            DestroyObject(Darkness);
            DestroyObject(PlatformOutline);
            DestroyObject(PlatformOutline1);
            Screenfollow.SetActive(true);
            creepyMusic.SetActive(false);
            normalMusic.SetActive(true);
        }
    }
}
