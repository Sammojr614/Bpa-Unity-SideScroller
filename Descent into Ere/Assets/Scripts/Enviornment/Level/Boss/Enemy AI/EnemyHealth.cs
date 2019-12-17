using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;

public class EnemyHealth : MonoBehaviour {

    public Animator EnemyHearts;

    public int enemyHealth;
    public static int enemyHealthStat;

    //The Enemy
    public GameObject enemy;

    //Hearts that display above the enemies head
    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;

    //Booleans, that check if the player has a specific heart
    public bool hasHeart1;
    public bool hasHeart2;
    public bool hasHeart3;
    public float invincibilityTime;
	
    /* On start, the enemy has all three hearts active,
     * and the static int enemyHealthStat is equal to the 
     * enemyHealth int
     */    
    void Start()
    {
        enemyHealthStat = enemyHealth;
        hasHeart1 = true;
        hasHeart2 = true;
        hasHeart3 = true;
    }

    /* Whenever the enemy is damaged,
     * it will take a certain amount of damage,
     * depending on the weapon, and will lose hearts accordingly
     * Also, the enemy's invincibility time will go up,
     * and will prevent the player for instantly killing the enemy
     */    
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
        }
        if (MagicAttack.magicDamage == true && invincibilityTime < 1f && hasHeart2 == true)
        {
            invincibilityTime++;
            hasHeart2 = false;
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

