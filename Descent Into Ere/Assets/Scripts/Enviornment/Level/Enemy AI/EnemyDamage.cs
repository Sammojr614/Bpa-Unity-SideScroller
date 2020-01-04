using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    //GameObject Player;
   
    void Start()
    {
        
        
        //Player = gameObject.transform.parent.gameObject;
    }
  
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Player")
        {
         PlayerHealth.damaged = true;
         PlayerHealth.health--;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        
        {
            PlayerHealth.damaged = false;
            
        }
    }

   
}
