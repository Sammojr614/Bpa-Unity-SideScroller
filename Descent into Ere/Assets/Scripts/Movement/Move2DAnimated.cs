using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2DAnimated : MonoBehaviour {
    //The speed the player moves
    public float moveSpeed = 5f;
    //Checks if the player is on the ground
    public bool isGrounded;

    //calling Out the animator and The Bools Needed
    public Animator PlayerAnimator;
    public GameObject Player;
    bool isJumping;
    float sprintActive;
    // Use this for initialization
    void Start () {
        PlayerAnimator = Player.GetComponent<Animator>();
    }
    //I used this alot, i made a Function for Moving
    void Move()
    {
        PlayerAnimator.SetFloat("Moving", 0.5f);
    }
    //To Make Things Easier i just wrote the Sprint out in a Funciton
    void OzulSprint()
    {
        PlayerAnimator.SetFloat("Moving", 1.0f);
    }

    // Update is called once per frame
    void Update () {
        Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
        Move();

        PlayerAnimator.SetFloat("Moving", 0.0f);
    }
    void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 8f), ForceMode2D.Impulse);

        }

    }
}

