using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlipperyPlatform : MonoBehaviour
{
    //Player
    public GameObject player;

    //Direction the player will slide
    private Vector3 MovingDirection;

    /* Upon entering the slippery platform trigger,
     * if the player is facing left, they will begin to slide left.
     * Conversly, if the player is facing right,
     * they will begin to slide right.
     */
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if(Flipper.facingLeft == true)
            {
                MovingDirection = Vector3.left;
            }
            else if(Flipper.facingLeft == false)
            {
                MovingDirection = Vector3.right;
            }
            player.transform.Translate(MovingDirection * Time.deltaTime);
        }
    }

    /* While colliding with the slippery platform trigger,
     * if the player is facing left, they will begin to slide left.
     * Conversly, if the player is facing right,
     * they will begin to slide right.
     */
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (Flipper.facingLeft == true)
            {
                MovingDirection = Vector3.left;
            }
            else if (Flipper.facingLeft == false)
            {
                MovingDirection = Vector3.right;
            }
            player.transform.Translate(MovingDirection * Time.deltaTime);
        }
    }

    //When the player exits the trigger, they will stop sliding
    void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}
