using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DoorEnter : MonoBehaviour {

    [SerializeField] private string newLevel;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetButtonDown("EnterDoor"))
            {
                SceneManager.LoadScene(newLevel);
            }
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetButtonDown("EnterDoor"))
            {
                SceneManager.LoadScene(newLevel);
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {

    }

}

