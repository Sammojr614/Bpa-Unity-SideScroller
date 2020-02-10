using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Speed the player moves
    private float moveSpeed = 5f;

    //Checks if the player is grounded
    public static bool isGrounded;

    //Player moves by using wsad or arrow keys
    void Update()
    {
        Debug.Log(isGrounded);

        Jump();
        Vector3 Movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += Movement * Time.deltaTime * moveSpeed;
    }

    /* If the player presses space while grounded,
     * they will jump
     */
    void Jump()
    {
        if(Input.GetButtonDown("Jump") && isGrounded == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(0f, 8f, 0f), ForceMode2D.Impulse);
        }
    }
}
