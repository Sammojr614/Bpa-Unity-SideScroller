using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicAttack : MonoBehaviour {

    //Magic ball used by the player
    public GameObject magicBall;

    //Not being used, will be removed
    public static float timeBtwAttack = 0f;

    //Boolean that tells when the player deals magicDamage
    public static bool magicDamage;

    //Determines whether the player can attack or not
    public static bool canAttack;

    //Moving direction for the ball
    private Vector3 MovingDirection = Vector3.right;

    /* On start, the player is not dealing any damage,
     * so magicDamage is set to false, and they can attack,
     * and the magicBall is set to false    
     */
	void Start () {
        magicBall.SetActive(false);
        magicDamage = false;
        canAttack = true;
	}

    // If the magic ball collides with the enemy, it will take damage
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            magicDamage = true;
        }
        else
        {
            magicDamage = false;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            magicDamage = true;
        }
        else
        {
            magicDamage = false;
        }
    }

    /* Whenever the player uses the magicBall, 
     * It's position will be updated using UpdateMovement();
     * and if it collides with the enemy,
     * it will dissapear, and deal magicDamage to the enemy
     */
    void Update()
    {
        UpdateMovement();
    }

    /* When the player presses q, the magic ball is activated and fired
     * If the player is facing left, the magic ball will be fired left,
     * and if the player is not facing left, the magic ball will be fired right.
     * After it is fired, it will return to the player and be turned off.    
     */
    void UpdateMovement()
    {
        if(Flipper.facingLeft == false)
        {
            if (Input.GetButtonDown("ManaAttack") && canAttack == true)
            {
                magicBall.SetActive(true);
                MovingDirection = Vector3.right;
                magicBall.transform.Translate(MovingDirection * 10f);
            }
            else if (Input.GetButtonUp("ManaAttack"))
            {
                MovingDirection = Vector3.left;
                magicBall.transform.Translate(MovingDirection * 10f);
                magicBall.SetActive(false);             
            }

        }
        else
        {
            if (Input.GetButtonDown("ManaAttack") && canAttack == true)
            {
                magicBall.SetActive(true);
                MovingDirection = Vector3.left;
                magicBall.transform.Translate(MovingDirection * 10f);
            }
            else if (Input.GetButtonUp("ManaAttack"))
            {
                MovingDirection = Vector3.right;
                magicBall.transform.Translate(MovingDirection * 10f);
                magicBall.SetActive(false);
            }
        }
    }

}
