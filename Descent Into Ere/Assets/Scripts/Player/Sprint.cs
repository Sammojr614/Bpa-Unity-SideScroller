using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprint : MonoBehaviour
{
    //Speed the player moves while sprinting
    private float sprintSpeed = 10f;

    /* If the player is on the ground, and has enough stamina (will be added later). 
     * Then while the player is holding the sprint button, the player will sprint
     */
    void Update()
    {
        while(Input.GetButton("Sprint") && PlayerMovement.isGrounded == true)
        {
            Vector3 Movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
            transform.position += Movement * Time.deltaTime * sprintSpeed;
            break;
        }
    }
}
