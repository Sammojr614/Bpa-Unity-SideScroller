using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorEnter : MonoBehaviour
{
    public string SceneName;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (Input.GetButtonDown("EnterDoor"))
            {
                SceneManager.LoadScene(SceneName);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (Input.GetButtonDown("EnterDoor"))
            {
                SceneManager.LoadScene(SceneName);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (Input.GetButtonDown("EnterDoor"))
            {
                SceneManager.LoadScene(SceneName);
            }
        }
    }
}
