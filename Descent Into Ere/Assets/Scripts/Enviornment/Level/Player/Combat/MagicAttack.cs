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

    public float startPos;

    private float endPos;

    /* On start, the player is not dealing any damage,
     * so magicDamage is set to false, and they can attack
     */
	void Start () {
        magicBall.SetActive(false);
        magicDamage = false;
        canAttack = true;
        endPos = startPos + 30f;
	}

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
            canAttack = false;
        }
        else
        {
            magicDamage = false;
            canAttack = true;
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

    /* When the player presses q, the magic ball's position
     * will move to right x times (this will probably change later),
     */
    void UpdateMovement()
    {
        if(Flipper.facingLeft == false)
        {
            if (Input.GetButtonDown("ManaAttack"))
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
    }

}
