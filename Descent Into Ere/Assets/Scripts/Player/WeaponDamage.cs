using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDamage : MonoBehaviour
{
    //The weapon
    [SerializeField] private Collider2D Weapon;

    //Ammount of damage
    [SerializeField] private int damage;

    //On Start, the weapon is disabled
     void Start()
     {
        Weapon.enabled = false;
     }

    /* If the player is attacking, and the player has enough stamina, the weapon is enabled,
     * If the player is NOT attacking, or does NOT have enough stamina, the weapon is disabled
     */
     void Update()
    {
        if (Input.GetButtonUp("Attack") || Sprint.stamina <= 0)
        {
            Weapon.enabled = false;
        }
        else if (Input.GetButtonDown("Attack") && Sprint.stamina > 0)
        {
            Weapon.enabled = true;
        }
        
        
    }

    /* If the player is attacking the enemy,
     * It will deal the ammount of damage, specified in the inspector,
     * And it will drain stamina from the player
     */
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            EnemyHealth enemy = collision.transform.GetComponent<EnemyHealth>();

            enemy.TakeDamage(damage);

            Sprint.stamina -= 5;
        }
    }

    /* When the player stops attacking, stamina will regenerate,
     * If the player has less than max stamina, it will regenreate,
     * If the player has max stamina, it will stop regenerating
     */
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (Sprint.stamina < 10)
        {
            Sprint.stamina += Time.deltaTime * 2.5f;
        }
        else
        {
            Sprint.stamina = 10;
        }
    }

}
