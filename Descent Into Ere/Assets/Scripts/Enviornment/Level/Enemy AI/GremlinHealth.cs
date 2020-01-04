using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GremlinHealth : MonoBehaviour
{
    //The Gremlin
    public GameObject gremlin;

    /* Since the gremlin only has 1 health,
     * if it gets damaged by the knife, 
     * steak knife, or magic, it will die and be destroyed
     */
     /*
    void Update()
    {
        if(Knife.damaged == true)
        {
            DestroyObject(gremlin);
            Knife.damaged = false;
        }
        else if(SteakKnife.damagedSteak == true)
        {
            DestroyObject(gremlin);
            SteakKnife.damagedSteak = false;
        }
        else if(MagicAttack.magicDamage == true)
        {
            DestroyObject(gremlin);
            MagicAttack.magicDamage = false;
        }
    }
    */

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && Knife.damaged == true)
        {
            DestroyObject(gremlin);
            Knife.damaged = false;
        }
        else if(collision.CompareTag("Player") && SteakKnife.damagedSteak == true)
        {
            DestroyObject(gremlin);
            SteakKnife.damagedSteak = false;
        }
        else if(collision.CompareTag("Player") && MagicAttack.magicDamage == true)
        {
            DestroyObject(gremlin);
            MagicAttack.magicDamage = false;
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && Knife.damaged == true)
        {
            DestroyObject(gremlin);
            Knife.damaged = false;
        }
        else if (collision.CompareTag("Player") && SteakKnife.damagedSteak == true)
        {
            DestroyObject(gremlin);
            SteakKnife.damagedSteak = false;
        }
        else if (collision.CompareTag("Player") && MagicAttack.magicDamage == true)
        {
            DestroyObject(gremlin);
            MagicAttack.magicDamage = false;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}
