using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprint : MonoBehaviour
{

    //Speed the character moves while sprinting
    public float sprintSpeed = 8f;
	public Animator PlayerAnimator;
    public bool isGrounded;
    public static bool canSprint;

	void Start(){
		PlayerAnimator = GetComponent<Animator> ();
        canSprint = true;
	}    
    
	void Update()
    {
        /* Allows player to sprint if they
         * Press the left shift button
         */
        if (Input.GetButton("Sprint") && isGrounded == true && canSprint == true)
        {
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
            transform.position += movement * Time.deltaTime * sprintSpeed;
            if(Input.GetButtonDown("Sprint")){
                PlayerAnimator.SetFloat ("Moving", 1.0f);
            }else{
                if(Input.GetButtonUp("Sprint")){
                    PlayerAnimator.SetFloat("Moving", 0.0f);
                }
            }
		
        }
		
  }

		
        
    }


