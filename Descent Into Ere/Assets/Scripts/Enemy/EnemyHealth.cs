using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public GameObject Enemy;

    [SerializeField] private int health;

    //On start, enemy is set active to true
    void Start()
    {
        Enemy.SetActive(true);
    }

    //How the enemy takes damage
    public void TakeDamage(int amount)
    {
        health -= amount;
        
        if(health <= 0)
        {
            Death();
        }
    }

    //When the enemy dies, it is destroyed
    void Death()
    {
        Destroy(Enemy);
    }
}
