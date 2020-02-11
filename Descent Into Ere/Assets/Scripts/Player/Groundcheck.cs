using UnityEngine;
using System.Collections;

public class Groundcheck : MonoBehaviour
{
    //If the player is on the ground, isGrounded = true
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            PlayerMovement.isGrounded = true;
        }
    }

    //If the player is NOT on the ground, isGrounded = false
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            PlayerMovement.isGrounded = false;
        }
    }
}
