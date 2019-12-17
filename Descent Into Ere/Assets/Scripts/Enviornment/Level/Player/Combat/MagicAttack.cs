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
     * so magicDamage is set to false, and they can attack
     */
	void Start () {
        magicDamage = false;
        canAttack = true;
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

    /* When the player presses q, the magic ball's position
     * will move to right x times (this will probably change later),
     */
    void UpdateMovement()
    {
        if (Input.GetButtonDown("ManaAttack"))
        {
            for (int i = 0; i < 300; i++)
            {
                MovingDirection = Vector3.right;
                this.transform.Translate(MovingDirection * Time.smoothDeltaTime);
            }
        }else if (Input.GetButtonUp("ManaAttack"))
        {
            for (int i = 0; i < 300; i++)
            {
                MovingDirection = Vector3.left;
                this.transform.Translate(MovingDirection * Time.smoothDeltaTime);
            }
        }
    }

}
