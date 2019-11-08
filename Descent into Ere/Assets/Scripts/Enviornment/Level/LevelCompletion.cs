using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompletion : MonoBehaviour
{
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
    }

