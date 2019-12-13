using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;

public class EnemyHealth : MonoBehaviour {

    public Animator EnemyHearts;

    public int enemyHealth;
    public static int enemyHealthStat;
    public GameObject enemy;
    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;
    public bool hasHeart1;
    public bool hasHeart2;
    public bool hasHeart3;
    public float invincibilityTime;
	
    void Start()
    {
        enemyHealthStat = enemyHealth;
        hasHeart1 = true;
        hasHeart2 = true;
        hasHeart3 = true;
    }

	void Update () {
        Debug.Log(invincibilityTime);
        if(Knife.damaged == true && hasHeart1 == true)
        {
            invincibilityTime++;
            hasHeart1 = false;
        }
        if (Knife.damaged == true && invincibilityTime < 1f && hasHeart2 == true)
        {
            invincibilityTime++;
            hasHeart2 = false;
        }
        if (Knife.damaged == true && invincibilityTime < 1f && hasHeart3 == true)
        {
            hasHeart3 = false;
            Knife.damaged = false;
        }
        if(SteakKnife.damagedSteak == true && hasHeart1 == true && hasHeart2 == true)
        {
            invincibilityTime++;
            hasHeart1 = false;
            hasHeart2 = false;
        }
        if(SteakKnife.damagedSteak == true && invincibilityTime < 1f && hasHeart3 == true)
        {
            hasHeart3 = false;
            SteakKnife.damagedSteak = false;
        }
        if (MagicAttack.magicDamage == true && hasHeart1 == true)
        {
            invincibilityTime++;
            hasHeart1 = false;
            MagicAttack.magicDamage = false;
        }
        if (MagicAttack.magicDamage == true && invincibilityTime < 1f && hasHeart2 == true)
        {
            invincibilityTime++;
            hasHeart2 = false;
            MagicAttack.magicDamage = false;
        }
        if (MagicAttack.magicDamage == true && invincibilityTime < 1f && hasHeart3 == true)
        {
            hasHeart3 = false;
            MagicAttack.magicDamage = false;
        }
        else if(invincibilityTime <= 1f || invincibilityTime >= 1f)
        {
            invincibilityTime -= 0.5f * Time.deltaTime;
            if(invincibilityTime <= 0f)
            {
                invincibilityTime = 0f;
            }
        }
        if (hasHeart1 == false)
        {
            DestroyObject(Heart1);
        }
        if(hasHeart2 == false)
        {
            DestroyObject(Heart2);
        }
        if (hasHeart3 == false)
        {
            DestroyObject(enemy);
        }



    }
}

