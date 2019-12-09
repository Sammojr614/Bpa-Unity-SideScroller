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

    /* Time between attacks, 
     * to prevent attacking more than once.
     */
    public float timeBtwAttack;

    void Start()
    {
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
        if(collision.CompareTag("Enemy") && Input.GetButton("SwordAttack"))
        {
            enemy.GetComponent<EnemyHealth>().enemyHealth -= damage;
            
        }
    }
}
