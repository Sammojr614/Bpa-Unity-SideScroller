using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprint : MonoBehaviour
{

    //Speed the character moves while sprinting
    public float sprintSpeed = 8f;
	public Animator PlayerAnimator;
	void Start(){
		PlayerAnimator = GetComponent<Animator> ();
	}    
	void Update()
    {
        /* Allows player to sprint if they
         * Press the left shift button
         */
        if (Input.GetKey(KeyCode.LeftShift))
        {
			PlayerAnimator.SetFloat ("Moving", 1.0f);
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
            transform.position += movement * Time.deltaTime * sprintSpeed;
		
        }


        /* Allows player to sprint if they
         * Press the right shift button
         */
        if (Input.GetKey(KeyCode.RightShift))
        {
			PlayerAnimator.SetFloat ("Moving", 1.0f);	
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
            transform.position += movement * Time.deltaTime * sprintSpeed;

        }
        
    }
}

