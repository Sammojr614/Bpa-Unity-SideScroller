using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Animator PlayerAnimator;
    private void Update()
    {
        Debug.Log(PlayerAnimator.GetFloat("Movement"));
        if (Input.GetButton("Horizontal") && !Input.GetButton("Sprint"))
        {
            PlayerAnimator.SetFloat("Movement", 0.5f);
        }else if(Input.GetButton("Sprint") && Input.GetButton("Horizontal"))
        {
            PlayerAnimator.SetFloat("Movement", 1.0f);
        }
        else
        {
            PlayerAnimator.SetFloat("Movement", 0.0f);
        }
        if (Input.GetButtonDown("MoveRight"))
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
           
        }
        if (Input.GetButtonDown("MoveLeft"))
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
            
        }
        
    }
}
