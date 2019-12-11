using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;

public class EnemyHealth : MonoBehaviour {

    public Animator EnemyHearts;
    public SpriteRenderer[] hearts;

    public int enemyHealth;
    public static int enemyHealthStat;
    public GameObject enemy;
	
    void Start()
    {
        enemyHealthStat = enemyHealth;
    }
	// Update is called once per frame
	void Update () {
        if (enemyHealth == 3)
        {
            EnemyHearts.SetFloat("EnemyHealth", 0.0f);
        }
        else
        {
            if (enemyHealth == 2)
            {
                EnemyHearts.SetFloat("EnemyHealth", 0.5f);
            }
            else
            {
                if (enemyHealth == 1)
                {
                    EnemyHearts.SetFloat("EnemyHealth", 1.0f);

                }
                else
                {
                    if (enemyHealth < 1)
                    {
                        enemyHealth = 0;
                        EnemyHearts.SetFloat("EnemyHealth", 1.5f);
                    }
                }
            }
            if(enemyHealth > 3)
            {
                enemyHealth = 3;
            }
        }

        if (Knife.damaged == true && enemyHealth != 0 && enemyHealth > 2)
        {
            enemyHealth--;
            EnemyHearts.SetBool("Damaged", Knife.damaged);
        }
        if (enemyHealth <= 0)
        {
            DestroyObject(enemy);
        }

    }
}
