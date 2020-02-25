using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    public GameObject Knife;
    public bool Drawn;
    public Transform KnifeTrans;
    public Transform PlayerTrans;
    public Animator PlayerAnimator;
    // Start is called before the first frame update
    void Start()
    {
        Knife.SetActive(false);
        Drawn = false;
    }

    // Update is called once per frame
    void Update()
    {
        KnifeTrans.rotation = PlayerTrans.rotation;
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
        if (Input.GetButtonDown("Attack") && Drawn == true)
        {
            PlayerAnimator.SetBool("Attacking", true);
        }else if (Input.GetButtonUp("Attack") && Drawn == true)
        {
            PlayerAnimator.SetBool("Attacking", false);
        }
       
    }
}
