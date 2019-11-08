using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Sword : MonoBehaviour {

    private float timeBtwAttack;
    public float startTimeBtwAttack;

    public Transform attackPos;
    public Animator PlayerAnimator;
    public LayerMask whatIsEnemies;
    public float attackRange;
    public int damage;
	
	// Update is called once per frame
	void Update () {
		if(timeBtwAttack <= 0)
        {
            if (Input.GetButton("SwordAttack"))
            {
                PlayerAnimator.SetBool("Attacking", true);
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies);
                for (int i = 0; i < enemiesToDamage.Length; i++)
                {
                    enemiesToDamage[i].GetComponent<EnemyHealth>().enemyHealth -= damage;
                }
            }
            timeBtwAttack = startTimeBtwAttack;
        
        }
        else
        {
            timeBtwAttack -= Time.deltaTime;
            PlayerAnimator.SetBool("Attacking", false);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }
}
