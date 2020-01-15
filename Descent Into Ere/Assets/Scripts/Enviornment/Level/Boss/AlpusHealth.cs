using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AlpusHealth : MonoBehaviour
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
    private float totalHealth;

    //Alpus
    public GameObject alpus;

    // On start, alpus has 20 health, invincibilityTime is set to 0f. 
    void Start()
    {
        invincibilityTime = 0f;
        totalHealth = 20f;
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

        if(totalHealth <= 0f)
        {
            DestroyObject(alpus);
            charge8.SetActive(false);
            Knife.damaged = false;
            SteakKnife.damagedSteak = false;
            MagicAttack.magicDamage = false;
            SceneManager.LoadScene("DevCreditScene");
        }

        if(totalHealth <= 17.5f)
        {
            charge1.SetActive(false);
        }

        if(totalHealth <= 15f)
        {
            charge2.SetActive(false);
        }

        if(totalHealth <= 12.5f)
        {
            charge3.SetActive(false);
        }

        if(totalHealth <= 10f)
        {
            charge4.SetActive(false);
        }

        if(totalHealth <= 7.5f)
        {
            charge5.SetActive(false);
        }

        if(totalHealth <= 5f)
        {
            charge6.SetActive(false);
        }

        if(totalHealth <= 2.5f)
        {
            charge7.SetActive(false);
        }
    }
}
