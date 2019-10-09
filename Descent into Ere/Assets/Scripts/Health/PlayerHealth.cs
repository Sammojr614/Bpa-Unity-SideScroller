﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    //Variables for health and number of hearts
    public static int health;
    int numOfHearts = 3;
//Damage
    public static bool damaged;
//Animator Stuff
public Animator PlayerAnimator;
    //Links the hearts to the script
    public SpriteRenderer[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    void Start(){
        PlayerAnimator.GetComponent<Animator>();
    }

    void Update()
    {  
        PlayerAnimator.SetBool("Damaged", damaged);
        Debug.Log(PlayerAnimator.GetBool("Damaged"));
        /*Makes sure the player's health
         * Doesn't exceed the number of hearts
         */
        if (health > numOfHearts)
        {
            health = numOfHearts;
        }


        for (int i = health; i < hearts.Length; i++)
        {
            
            /* Makes the game display a full heart
             * when the player is at full health
             */
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            /* Makes the game display an empty heart
             * when the player takes damage
             */
            else
            {
                hearts[i].sprite = emptyHeart;

            }

            /* Makes sure the health displayed
             * Isn't greater that the number of hearts
             */
            if(i < numOfHearts){
                hearts[i].enabled = true;
            }else{
                hearts[i].enabled = false;
            }
            if(damaged == true && health != 0 && health > 2){
                health -= 1;
                break;
            }
            if(health == 0)
            {
                SceneManager.LoadScene("EnemyTesting");
            }
        }
    }

    
}