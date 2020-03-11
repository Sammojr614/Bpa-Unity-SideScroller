using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    public GameObject Knife;
    public static bool Drawn;
    public Transform KnifeTrans;
    public Transform PlayerTrans;
    public Animator PlayerAnimator;
                                /* This Script is For Controlling the Animations For the Steak/Butter Knives*/
    void Start()
    {
        Knife.SetActive(false);
        Drawn = false;
    }

    
    void Update()
    {
        //this here is Controlling when the Knife GameObject is Enabled or not
        if (Input.GetButtonDown("DrawWepon") && Drawn == false)
        {
            Knife.SetActive(true);
            Drawn = true;
        }
        else if (Input.GetButtonDown("DrawWepon") && Drawn == true)
        {
            Knife.SetActive(false);
            Drawn = false;
        }
        //This Is The Animation Control
        if (Input.GetButtonDown("Attack") && Drawn == true)
        {
            PlayerAnimator.SetBool("Attacking", true);
        }else if (Input.GetButtonUp("Attack") && Drawn == true)
        {
            PlayerAnimator.SetBool("Attacking", false);
        }
       
    }
}
