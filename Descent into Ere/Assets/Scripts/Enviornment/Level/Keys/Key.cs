using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

    //The key and obsticle in the level
    public GameObject key;
    
   
    /* When the player collides with
     * the key, the key dissapears
     * and the obsticle is destroyed
     */    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            key.SetActive(false);
            Inventory.haveKey = true;
			Inventory.NumberOfItems++;
        }
    }

    /* While the player is colliding with
     * the key, the key will dissapear
     * and the obsticle will be destroyed
     */    
    private void OnTriggerStay2D(Collider2D collision)
	{
		if (collision.CompareTag ("Player")) {
			key.SetActive (false);
			Inventory.haveKey = true;
		}
	}
}
