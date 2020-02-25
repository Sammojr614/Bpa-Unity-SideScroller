using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoDamage : MonoBehaviour
{
    public Collider2D DamageDoer;
    //My Attempt at a Damage Script 
     void Start()
    {
        DamageDoer.enabled = false;
    }
     void Update()
    {
        if (Input.GetButtonUp("Attack"))
        {
            DamageDoer.enabled = false;
        }else if (Input.GetButtonDown("Attack"))
        {
            DamageDoer.enabled = true;
        }
        
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (DamageDoer.CompareTag("Enemy"))
        {
            EnemyHealth.EHealth = EnemyHealth.EHealth - 1;
        }
    }

}
