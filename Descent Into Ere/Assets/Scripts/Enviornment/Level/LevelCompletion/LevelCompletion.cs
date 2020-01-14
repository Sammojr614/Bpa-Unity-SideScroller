using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompletion : MonoBehaviour
{
    //Checks if each level is complete or not
    public static bool playerDreamComplete;
    public static bool lucidComplete;
    public static bool nightmareComplete;

    public static int LevelComplete;

    //Checkmarks outside each levels door
    public GameObject playerDreamCheckmark;
    public GameObject lucidCheckmark;
    public GameObject nightmareCheckmark;

    // On Start, all checkmarks are disabled, as the player hasn't cleared any levels yet
    void Start()
    {
        playerDreamCheckmark.SetActive(false);
        lucidCheckmark.SetActive(false);
        nightmareCheckmark.SetActive(false);
    }

    /* Everytime a level is cleared, a boolean indicating that level has been complete,
     * will be set to true, and a checkmark will appear outside the level's door in mainhub,
     * signifying that this level has been completed
     */    
    void Update()
    {
        if(playerDreamComplete == true)
        {
            playerDreamCheckmark.SetActive(true);
        }

        if(lucidComplete == true)
        {
            lucidCheckmark.SetActive(true);
        }

        if(nightmareComplete == true)
        {
            nightmareCheckmark.SetActive(true);
        }
    }
    /*
     public GameObject key;
    public GameObject ExitDoor;
    public static int LevelComplete;
    void Start(){
        ExitDoor.SetActive(false);
    }
    

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            LevelDoorController.LucidLocked = false;
            key.SetActive(false);
            ExitDoor.SetActive(true);
            LevelComplete++;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
           LevelDoorController.LucidLocked = false;
            key.SetActive(false);
            ExitDoor.SetActive(true);
            LevelComplete++;
           
           }
        }
        */
}

