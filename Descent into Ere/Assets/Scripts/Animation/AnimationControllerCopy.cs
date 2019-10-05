using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatonControllerCopy : MonoBehaviour
{
    //calling Out the animator and The Bools Needed
    public Animator OzulAnimator;
    public GameObject Player;
    bool isJumping;
    float sprintActive;

    void Start()
    {
        OzulAnimator = Player.GetComponent<Animator>();
    }
    //I used this alot, i made a Function for Moving
    void Move()
    {
        OzulAnimator.SetFloat("Moving", 0.5f);
    }
    //To Make Things Easier i just wrote the Sprint out in a Funciton
    void OzulSprint()
    {
        OzulAnimator.SetFloat("Moving", 1.0f);
    }

    void Update()
    {
        //Key Code D
        if (Input.GetKey(KeyCode.D))
        {
            Move();
        }
        //Key Code A
        if (Input.GetKey(KeyCode.A))
        {
            Move();
        }
        //Left Arrow Key
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Move();
        }
        //Right Arrow Key
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Move();
        }
        OzulAnimator.SetFloat("Moving", 0.0f);
        //Left Shift
        if (Input.GetKey(KeyCode.LeftShift))
        {
            OzulSprint();
        }
        //Right Shift
        if (Input.GetKey(KeyCode.RightShift))
        {
            OzulSprint();
        }
        OzulAnimator.SetFloat("Moving", 0.0f);


    }
}
