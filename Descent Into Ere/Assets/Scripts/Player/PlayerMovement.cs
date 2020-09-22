using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public static int moveSpeed = 5;

    // Update is called once per frame
    void Update()
    {
        Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
    }
    void Jump()
    {
        if (Input.GetButtonDown("Jump") && Groundcheck.isGrounded == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(0f, 5f, 0f), ForceMode2D.Impulse);
        }
    }
}
