using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossKey : MonoBehaviour {

    //The key and obsticle in the level
    public GameObject BossKeyGameObject;
    
	void Update(){
		if (Inventory.haveBossKey == true) {
			BossKeyGameObject.SetActive (false);
		} else {
			BossKeyGameObject.SetActive (true);
		}
	}
    /* When the player collides with
     * the key, the key dissapears
     * and the obsticle is destroyed
     */    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            BossKeyGameObject.SetActive(false);
            Inventory.haveBossKey = true;
			Inventory.NumberOfItems++;
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
            BossKeyGameObject.SetActive(false);
            Inventory.haveBossKey = true;
        }
    }

    /* After the player exits the trigger,
     * the key has vanished, and the 
     * obsticle is gone
     */    
    
   



}
