using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{


    void OnCollisionEnter2D(Collision2D _collision)
    {
        if (_collision.gameObject.tag=="Player")
        {
            gameObject.GetComponent<PlayerHealth>().health = gameObject.GetComponent<PlayerHealth>().health - 1;
        }
    }
}
