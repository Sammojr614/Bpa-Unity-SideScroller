using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampLight : MonoBehaviour {

    //Lamplight
    public GameObject lampLight;

    //On start, the light is off
	void Start () {
        lampLight.SetActive(false);
	}

    /* When the player enters the trigger of the lamp post, 
     * the lamp light will turn on
     */
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            lampLight.SetActive(true);
        }
    }

    /* While the player is in the trigger of the lamp post,
     * the lamp light will stay on
     */
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            lampLight.SetActive(true);
        }
    }

    /* When the player exits the trigger of the lamp post,
     * the lamp light will turn off
     */
    void OnTriggerExit2D(Collider2D collision)
    {
        lampLight.SetActive(false);
    }


}
