using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;
using UnityEngine.SceneManagement;
using System.Data;
using System.IO;
using Mono.Data.Sqlite;
using System;

public class PlayerHealth : MonoBehaviour
{
    //Variables for health and number of hearts
	public static int health;
    int numOfHearts = 3;
//Damage
    public static bool damaged;
//Animator Stuff
public Animator PlayerAnimator;
Animation PlayerAnimation;
	SpriteRenderer[] Heart;
    void Start(){
		PlayerAnimator = gameObject.GetComponent<Animator> ();
		//Connection String
		IDbConnection dbCon = new SqliteConnection (NewData.connectionString);
		//Opening Database
		dbCon.Open ();
		//The Database Reader
		IDataReader dbReader;
		//SQL Commands
		IDbCommand dbCmd = dbCon.CreateCommand ();
		//Command Text
		string checkHealth = "SELECT PlayerHealth FROM PlayerSaveData";
		//Setting Command Text
		dbCmd.CommandText = checkHealth;
		//Reading From Database
		dbReader = dbCmd.ExecuteReader ();
		//What we Need the Reader to Do While it is Reading
		while (dbReader.Read ()) {
			health = Convert.ToInt32 (dbReader[0].ToString ());
		}
		dbReader.Close ();
		dbCon.Close();
    }

    void Update()
	{  
		if (health == 3) {
			PlayerAnimator.SetFloat ("Health", 0.0f);
		} else {
			if (health == 2) {
				PlayerAnimator.SetFloat ("Health", 0.5f);
			} else {
				if (health == 1) {
					PlayerAnimator.SetFloat ("Health", 1.0f);
					
				} else {
					if (health < 1) {
						health = 0;
						PlayerAnimator.SetFloat ("Health", 1.5f);
					}
				}
		
       
				if (damaged == true && health != 0 && health > 2) {
					health -= 1;
					PlayerAnimator.SetBool ("Damaged", damaged);

				}
				if (PlayerLives.Lives == 0) {
					SceneManager.LoadScene ("GameOver");
				}
          
			}
		}

	}   
}
