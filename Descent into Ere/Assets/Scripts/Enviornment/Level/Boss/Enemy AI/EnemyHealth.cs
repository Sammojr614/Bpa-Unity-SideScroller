using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;

public class EnemyHealth : MonoBehaviour {

    public Animator EnemyHearts;

    public int enemyHealth;
    public static int enemyHealthStat;
    public GameObject enemy;
	
    void Start()
    {
        enemyHealthStat = enemyHealth;
    }
	// Update is called once per frame
	void Update () {
        if (Knife.damaged == true && enemyHealth != 0 || enemyHealth < 3 && enemyHealth > 1)
        {
            enemyHealth -= Knife.knifeDamage;
        }
        if (enemyHealth <= 0)
        {
            DestroyObject(enemy);
        }

    }
}
