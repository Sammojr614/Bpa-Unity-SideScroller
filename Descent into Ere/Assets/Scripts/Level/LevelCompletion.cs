using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompletion : MonoBehaviour
{
    public GameObject key;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("MainHub");
            key.GetComponent<DoorEnter>().DoorLocked = false;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("MainHub");
            key.GetComponent<DoorEnter>().DoorLocked = false;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {

    }


}
