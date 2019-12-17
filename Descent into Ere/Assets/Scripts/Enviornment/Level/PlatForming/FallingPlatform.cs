using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour {

    Rigidbody2D rb;

	//Rigidbody
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
    //Method checks if player collides with platform
	void OnCollisionEnter2D (Collision2D other) {
        /* If the player collides with the platform,
         * the platform will fall
         */
		if (other.gameObject.tag.Equals("Player"))
        {
            Invoke("DropPlatform", 0.25f);
            Destroy(gameObject, 2f);
        }
    }

    //Method that allows the platform to drop
    void DropPlatform()
    {
        rb.isKinematic = false;
    }
}
