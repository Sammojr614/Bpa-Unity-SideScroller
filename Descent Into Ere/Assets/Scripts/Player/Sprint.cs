using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprint : MonoBehaviour
{
    //Speed the player moves while sprinting
    private float sprintSpeed = 10f;

    //Total stamina the player has
    public static float stamina = 10f;

    //Determines if the player is sprinting or not
    private bool sprinting;

    /* If the player is on the ground, and has enough stamina. 
     * Then while the player is holding the sprint button, the player will sprint.
     * If the player is NOT grounded, or does NOT have enough stamina, they cannot sprint.
     */
    void Update()
    {
        /*
        Debug.Log(stamina);
        */

        if(Input.GetButton("Sprint") && PlayerMovement.isGrounded == true && stamina > 0f && Input.GetButton("Horizontal"))
        {
            stamina -= Time.deltaTime * 5;

            sprinting = true;

            Vector3 Movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
            transform.position += Movement * Time.deltaTime * sprintSpeed;
        }
        else
        {
            sprinting = false;
        }

        
        /* If the player has less than 10 stamina, and is NOT sprinting,
         * the player will begin to regenerate stamina.
         * If the player has equal or higher than 10 stamina,
         * the player's stamina will be set equal to 10.
         */
        if(stamina < 10f && sprinting == false)
        {
            stamina += Time.deltaTime * 5;
        }
        else if(stamina > 10f)
        {
            stamina = 10f;
        }
    }
}
