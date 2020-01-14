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
    public GameObject charge7;
    public GameObject charge8;

    //Invinicbility time after each attack
    private float invincibilityTime;

    //Total health executioner has
    private float totalHealth;

    //Executioner
    public GameObject executioner;

    //Exit door after the boss dies
    public GameObject exit;


    /* On start, the executioner has 12 total health,
     * invincibility time is set to 0f,
     * and the exit door is disabled
     */
    void Start()
    {
        invincibilityTime = 0f;
        totalHealth = 12f;
        exit.SetActive(false);
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
            exit.SetActive(true);
            charge8.SetActive(false);
            Knife.damaged = false;
            SteakKnife.damagedSteak = false;
            MagicAttack.magicDamage = false;
        }

        if(totalHealth <= 10.5f)
        {
            charge1.SetActive(false);
        }

        if(totalHealth <= 9f)
        {
            charge2.SetActive(false);
        }

        if(totalHealth <= 7.5f)
        {
            charge3.SetActive(false);
        }

        if(totalHealth <= 6f)
        {
            charge4.SetActive(false);
        }

        if(totalHealth <= 4.5f)
        {
            charge5.SetActive(false);
        }

        if(totalHealth <= 3f)
        {
            charge6.SetActive(false);
        }

        if(totalHealth <= 1.5f)
        {
            charge7.SetActive(false);
        }
    }
}
