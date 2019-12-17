using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Move2D : MonoBehaviour
{
	//The speed the player moves
	public float moveSpeed = 5f;
	//Checks if the player is on the ground
	public bool isGrounded;
	//Random Dance
	float DANCE;
	//Jumping Animation
	float isJumping;
	// Moving Float
	float isMoving;
	//Giving the Program The Animator
	public Animator PlayerAnimator;
	//Getting The Animator
	void Start()
	{
		PlayerAnimator = GetComponent<Animator>();
		PlayerAnimator.SetBool("IsGrounded", isGrounded);
	}


	/* Allows the player to move, by using l/r arrow keys 
     * Or wasd on the keyboard 
     * (a left, d right)
     */
	void OzulMoving()
	{
		PlayerAnimator.SetFloat("Moving", 0.5f);
	}

	void Update()
	{
		PlayerAnimator.SetBool("IsGrounded", isGrounded);
        
		Jump();
		Vector3 movementRight = new Vector3(Input.GetAxis("MoveRight"), 0f, 0f);
		transform.position += movementRight * Time.deltaTime * moveSpeed;

		Vector3 movementLeft = new Vector3(Input.GetAxis("MoveLeft"), 0f, 0f);
		transform.position += movementLeft * Time.deltaTime * moveSpeed;
		//Saying if Any Key: Left Arrow, A, D , or Right Arrow Will Make The Walking Peram Change
		if (Input.GetButtonDown("Horizontal"))
		{
			OzulMoving();
		}
		else
		{
			if (Input.GetButtonUp("Horizontal"))
			{
				PlayerAnimator.SetFloat("Moving", 0.0f);
			}


		}
	}




		//Allows the player to jump, if they are on the ground
		void Jump()
		{
			if (Input.GetButtonDown("Jump") && isGrounded == true)
			{
				gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 8f), ForceMode2D.Impulse);

			}
			
				// Setting The Jump Peram

				if (Input.GetButtonUp("Jump") && isGrounded == true)
				{
					PlayerAnimator.SetFloat("Jumping", 1.0f);


				}


			}
		}

	
