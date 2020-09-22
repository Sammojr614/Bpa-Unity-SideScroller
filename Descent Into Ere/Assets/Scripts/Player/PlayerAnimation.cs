using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator PlayerAnimator;
    public SpriteRenderer Player;
    private void Update()
    {

        if (Input.GetButton("Horizontal") && Groundcheck.isGrounded != false)
        {
            PlayerAnimator.SetFloat("movement", 1f);
            if (Input.GetButtonDown("moveLeft"))
            {
                Player.flipX = true;
            }
            else if (Input.GetButtonDown("moveRight"))
            {
                Player.flipX = false;
            }
        }
        else if (!Input.GetButton("Horizontal") && Groundcheck.isGrounded != false) 
        {
            PlayerAnimator.SetFloat("movement", 0f);
        }

    }
}
