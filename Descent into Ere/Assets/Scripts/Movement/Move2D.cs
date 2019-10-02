using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Move2D : MonoBehaviour
{
    //The speed the player moves
    public float moveSpeed = 5f;
    //Checks if the player is on the ground
    public bool isGrounded ;
   
    //Allows the player to move
    void Update()
    {
        Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
		transform.position += movement * Time.deltaTime * moveSpeed;


    }

    //Allows the player to jump
    void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 8f), ForceMode2D.Impulse);
        }
        
    }
}
