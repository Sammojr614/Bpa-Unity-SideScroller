using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour {

    //Knife the player uses
    public GameObject knife;

    GameObject enemy;
    //Tells the game if player is attacking
    public bool isAttacking = false;
    //Damage player deals with weapon
    public int damage;
    public static int knifeDamage;

    /* Time between attacks, 
     * to prevent attacking more than once.
     */
    public static float timeBtwAttack = 1f;

    public static bool damaged;

    void Start()
    {
        damaged = false;
        knifeDamage = damage;
    }
    /* When an enemy enters the trigger,
     * of the players knife, the attack button,
     * v, is pressed, and the player is not already attacking,
     * the enemy will take damage, set in unity,
     * and the player will be unable to attack again,
     * until the time between attacks is at 0
     */
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(timeBtwAttack);
        if(timeBtwAttack <= 0)
        {
            if (collision.CompareTag("Enemy"))
            {
                if (Input.GetButtonDown("SwordAttack"))
                {
                    damaged = true;
                }
                else
                {
                    damaged = false;
                }
            }
        }
        else
        {
            timeBtwAttack -= Time.deltaTime;
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (timeBtwAttack <= 0)
        {
            if (collision.CompareTag("Enemy"))
            {
                if (Input.GetButtonDown("SwordAttack"))
                {
                    damaged = true;
                }
                else
                {
                    damaged = false;
                }
            }
        }
        else
        {
            timeBtwAttack -= Time.deltaTime;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {

    }
}
