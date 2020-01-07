using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HangmanHealth : MonoBehaviour
{

    //Healthbar charges
    public GameObject charge1;
    public GameObject charge2;
    public GameObject charge3;
    public GameObject charge4;
    public GameObject charge5;
    public GameObject charge6;
    public GameObject charge7;
    public GameObject charge8;

    //InvincibilyTime after each attack
    private float invincibilityTime;
    //TotalHealth the boss has
    private int totalHealth;

    //Hangman
    public GameObject hangman;
    //Exit that appears after hangman is defeated
    public GameObject exit;

    //Hangman has 16 health, and invicibility time is 0f on start
    void Start()
    {
        invincibilityTime = 0f;
        totalHealth = 16;
        exit.SetActive(false);
    }

    void Update()
    {
        Debug.Log(totalHealth);
        /* If the player attacks with a knife, or magic,
         * Hangman will take one damage, and invincibility time will incriment by one.
         * If the player attacks with the steak knife,
         * Hangman will take two damage, and invincibility time will incriment by one.
         */
        if(Knife.damaged == true && invincibilityTime <= 0f)
        {
            invincibilityTime++;
            totalHealth -= 1;
        }
        if(SteakKnife.damagedSteak == true && invincibilityTime <= 0f)
        {
            invincibilityTime++;
            totalHealth -= 2;
        }
        if(MagicAttack.magicDamage == true && invincibilityTime <= 0f)
        {
            invincibilityTime++;
            totalHealth -= 1;
        }

        if(invincibilityTime > 0f)
        {
            invincibilityTime -= 0.5f * Time.deltaTime;
        }
        else if(invincibilityTime <= 0f)
        {
            invincibilityTime = 0f;
        }

        /* When hangman reaches zero health,
         * he will die, and the final healthbar charge will be disabled.
         * Also, the Knife, SteakKnife, and MagicAttack will stop doing damage,
         * to not continously drain stamina/mana from the player
         */
        if(totalHealth <= 0)
        {
            DestroyObject(hangman);
            charge8.SetActive(false);
            Knife.damaged = false;
            SteakKnife.damagedSteak = false;
            MagicAttack.magicDamage = false;
            exit.SetActive(true);
        }

        //Every 2 health hangman loses, a charge is disabled
        if (totalHealth <= 14)
        {
            charge1.SetActive(false);
        }
        if (totalHealth <= 12)
        {
            charge2.SetActive(false);
        }
        if (totalHealth <= 10)
        {
            charge3.SetActive(false);
        }
        if (totalHealth <= 8)
        {
            charge4.SetActive(false);
        }
        if (totalHealth <= 6)
        {
            charge5.SetActive(false);
        }
        if (totalHealth <= 4)
        {
            charge6.SetActive(false);
        }
        if (totalHealth <= 2)
        {
            charge7.SetActive(false);
        }
    }
}
