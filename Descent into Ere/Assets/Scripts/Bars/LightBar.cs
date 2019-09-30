using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LightBar : MonoBehaviour {

    Animator anim;
    private float x;
    private float y;
    private float sprint;

    private Move2D controller;

    public float slowSpeed = 3f;

    //Total amount of stamina
    public float amount = 100f;

    //Amount of stamina drained
    public float drainAmount = 5f;
    //Amount of stamina regenerated
    public float regenAmount = 5f;
	// Use this for initialization
	void Start () {
        controller = GameObject.FindObjectOfType<Move2D>();
	}
	
	// Update is called once per frame
	void Update () {
        //Buttons for sprinting
        bool isRunning = Input.GetKey(KeyCode.LeftShift);
        bool isRunningRight = Input.GetKey(KeyCode.RightShift);

        /* If the player is sprinting
         * The player will lose stamina
         */
        if (isRunning || isRunningRight)
        {
            amount -= Time.deltaTime * drainAmount;
        }
        else
        {
            /* If the player has full stamina
             * They will not regenerate anymore
             */
            if(amount >= 100f)
            {
                return;
            }
            /* If the player is no longer sprinting
             * The player will regenrate stamina
             */
            amount += Time.deltaTime * regenAmount;
        }

        
        if(amount == 0f)
        {
            
        }

        void sprinting () {
            if (Input.GetKey(KeyCode.LeftShift))
            {

            }
        }
        
        

    }
}
