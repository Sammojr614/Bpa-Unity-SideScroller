using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompletion : MonoBehaviour
{
     public GameObject key;
    public GameObject ExitDoor;
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
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
           LevelDoorController.LucidLocked = false;
            key.SetActive(false);
            ExitDoor.SetActive(true);
           }
        }
    }

