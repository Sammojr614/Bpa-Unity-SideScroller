using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

    //The key and obsticle in the level
    public GameObject key;
    public GameObject Obsticle;

    /* When the player collides with
     * the key, the key dissapears
     * and the obsticle is destroyed
     */    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            DestroyObject(Obsticle);
            key.SetActive(false);
        }
    }

    /* While the player is colliding with
     * the key, the key will dissapear
     * and the obsticle will be destroyed
     */    
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            DestroyObject(Obsticle);
            key.SetActive(false);
        }
    }

    /* After the player exits the trigger,
     * the key has vanished, and the 
     * obsticle is gone
     */    
    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}
