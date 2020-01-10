using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExecutionerHealth : MonoBehaviour
{

    //Healthbar charges
    public GameObject charge1;
    public GameObject charge2;
    public GameObject charge3;
    public GameObject charge4;
    public GameObject charge5;
    public GameObject charge6;

    //Invinicbility time after each attack
    private float invincibilityTime;

    //Total health executioner has
    private int totalHealth;

    //Executioner
    public GameObject executioner;

    //Exit door after the boss dies
    public GameObject exit;

    //Main boss
    public GameObject bossMain;

    //Bottle boss
    public GameObject bossBottle;

    /* On start, the executioner has 12 total health,
     * invincibility time is set to 0f,
     * and the exit door is disabled
     */    
    void Start()
    {
        invincibilityTime = 0f;
        totalHealth = 12;
        exit.SetActive(false);
        bossMain.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(totalHealth);

        if (Knife.damaged == true && invincibilityTime <= 0f)
        {
            invincibilityTime++;
            totalHealth -= 1;
        }
        if (SteakKnife.damagedSteak == true && invincibilityTime <= 0f)
        {
            invincibilityTime++;
            totalHealth -= 2;
        }
        if (MagicAttack.magicDamage == true && invincibilityTime <= 0f)
        {
            invincibilityTime++;
            totalHealth -= 1;
        }

        if (invincibilityTime > 0f)
        {
            invincibilityTime -= 0.5f * Time.deltaTime;
        }
        else if (invincibilityTime <= 0f)
        {
            invincibilityTime = 0f;
        }

        if(totalHealth <= 0)
        {
            DestroyObject(executioner);
            charge6.SetActive(false);
            Knife.damaged = false;
            SteakKnife.damagedSteak = false;
            MagicAttack.magicDamage = false;
            exit.SetActive(true);
        }

        if(totalHealth <= 10)
        {
            charge1.SetActive(false);
        }

        if(totalHealth <= 8)
        {
            charge2.SetActive(false);
        }

        if(totalHealth <= 6)
        {
            charge3.SetActive(false);
            bossMain.SetActive(true);
        }

        if(totalHealth <= 4)
        {
            charge4.SetActive(false);
        }

        if(totalHealth <= 2)
        {
            charge5.SetActive(false);
        }
    }
}
