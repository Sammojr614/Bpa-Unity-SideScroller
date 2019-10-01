using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprint : MonoBehaviour
{

    //Speed the character sprints
    public float sprintSpeed = 8f;

    // Update is called once per frame
    void Update()
    {
        /* Allows player to sprint if they
         * Press the left shift button
         */
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
            transform.position += movement * Time.deltaTime * sprintSpeed;
        }

        /* Allows player to sprint if they
         * Press the right shift button
         */
        if (Input.GetKey(KeyCode.RightShift))
        {
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
            transform.position += movement * Time.deltaTime * sprintSpeed;
        }
        
    }
}

