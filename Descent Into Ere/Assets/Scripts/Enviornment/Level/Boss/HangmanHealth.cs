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

    //Hangman has 16 health, and invicibility time is 0f on start
    void Start()
    {
        invincibilityTime = 0f;
        totalHealth = 16;
    }


    // Update is called once per frame
    void Update()
    {
        Debug.Log(totalHealth);
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

        if(totalHealth <= 0)
        {
            DestroyObject(hangman);
            charge8.SetActive(false);
        }

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
