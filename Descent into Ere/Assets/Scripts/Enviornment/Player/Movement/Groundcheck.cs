using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Groundcheck : MonoBehaviour
{
	
    GameObject Player;

    void Start()
    {
        Player = gameObject.transform.parent.gameObject;
    }

    /* If the player is on the ground
     * The player can jump
     */
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            Player.GetComponent<Move2D>().isGrounded = true;
            Player.GetComponent<Sprint>().isGrounded = true;

        }
    }
    /* If the player is not on the ground
     * The player cannot jump
     */
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            Player.GetComponent<Move2D>().isGrounded = false;
            Player.GetComponent<Sprint>().isGrounded = false;
        }
    }
}
