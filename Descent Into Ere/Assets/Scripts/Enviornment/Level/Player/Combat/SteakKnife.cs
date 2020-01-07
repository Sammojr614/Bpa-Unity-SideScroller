using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteakKnife : MonoBehaviour {

    public GameObject steakKnifeRight;
    public GameObject steakKnifeLeft;

    public static float timeBtwAttack = 1f;

    public static bool damagedSteak;

    public static bool canAttack;

	void Start () {
        damagedSteak = false;
        canAttack = true;
	}

    /* When an enemy enters the trigger,
     * of the players knife, the attack button,
     * e, is pressed, and the player is not already attacking,
     * the enemy will take damage, set in unity,
     * and the player will be unable to attack again,
     * until the time between attacks is at 0
     */
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(timeBtwAttack);
        if (timeBtwAttack <= 0)
        {
            if (collision.CompareTag("Enemy"))
            {
                if (Input.GetButtonDown("SwordAttack") && canAttack == true)
                {
                    damagedSteak = true;
                }
                else
                {
                    damagedSteak = false;
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
                if (Input.GetButtonDown("SwordAttack") && canAttack == true)
                {
                    damagedSteak = true;
                }
                else
                {
                    damagedSteak = false;
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
