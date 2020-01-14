using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LucidDoor : MonoBehaviour {

    //Newlevel set in unity
    public string newLevel;
    //Locked gameobject that appears over door
    public GameObject locked;

    //On start, the door is locked, and will have the locked gameobject enabled
    void Start()
    {
        locked.SetActive(true);
    }

    /* Once the player completes playerdream,
     * the locked gameobject will dissapear,
     * and the door will be unlocked
     */
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(LevelCompletion.playerDreamComplete == true)
        {
            locked.SetActive(false);
            if (collision.CompareTag("Player"))
            {
                if (Input.GetButtonDown("EnterDoor"))
                {
                    SceneManager.LoadScene(newLevel);
                }
            }
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (LevelCompletion.playerDreamComplete == true)
        {
            locked.SetActive(false);
            if (collision.CompareTag("Player"))
            {
                if (Input.GetButtonDown("EnterDoor"))
                {
                    SceneManager.LoadScene(newLevel);
                }
            }
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            
        }
    }

}
