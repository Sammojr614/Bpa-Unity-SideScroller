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

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && Knife.damaged == true)
        {
            gremlin.SetActive(false);
        }
        else if(collision.CompareTag("Player") && SteakKnife.damagedSteak == true)
        {
            gremlin.SetActive(false);
        }
        else if(collision.CompareTag("Player") && MagicAttack.magicDamage == true)
        {
            gremlin.SetActive(false);
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && Knife.damaged == true)
        {
            gremlin.SetActive(false);
        }
        else if (collision.CompareTag("Player") && SteakKnife.damagedSteak == true)
        {
            gremlin.SetActive(false);
        }
        else if (collision.CompareTag("Player") && MagicAttack.magicDamage == true)
        {
            gremlin.SetActive(false);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        Knife.damaged = false;
        SteakKnife.damagedSteak = false;
        MagicAttack.magicDamage = false;
    }
}
