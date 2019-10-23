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

	public void commandQuery(string commandText){
		using (SqliteConnection dbCon = new SqliteConnection (DatabaseStatics.connectionString)) {
			dbCon.Open ();
			using (SqliteCommand dbCmd = new SqliteCommand (commandText, dbCon)) {
				dbCmd.ExecuteNonQuery ();
			}
		}
	}
	public void readerQuery(string readText){
		using(SqliteConnection dbCon = new SqliteConnection(DatabaseStatics.connectionString)){
			dbCon.Open ();
			using(SqliteCommand dbCmd = new SqliteCommand(readText,dbCon)){
				using (SqliteDataReader dbReader = dbCmd.ExecuteReader ()) {
					while (dbReader.Read ()) {
						health = Convert.ToInt32 (dbReader [2].ToString ());
					}
				}
			}
		}
	}
    void Start(){
		readerQuery ("SELECT*FROM PlayerSaveData");
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
