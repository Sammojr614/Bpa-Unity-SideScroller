using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Animator PlayerAnimator;
    private void Update()
    {
        if (Input.GetButton("Horizontal"))
        {
            PlayerAnimator.SetFloat("Movement", 0.5f);
        }else if(Input.GetButton("Horizontal") && Input.GetButton("Sprint"))
        {
            PlayerAnimator.SetFloat("Movement", 1.0f);
        }
        else
        {
            PlayerAnimator.SetFloat("Movement", 0.0f);
        }

    }
}
