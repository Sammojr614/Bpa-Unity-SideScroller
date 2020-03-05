using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public static int health;
    public static int lives;
    public Text LivesDisplay;
    public GameObject[] healthBarCharges;
    DbManager dataManager = DbManager.Instance;
    public static bool gameOver;

    private string insertThis;
    private string putThisIn;
    
    void Start()
    {
        //Making Sure The Values are Read and Set From the Database
        dataManager.ReadingData("SELECT*FROM PlayerSaveData");

        playerData();

    }
    //if the Player is to Touch an Enemy 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            if (!Input.GetButton("Attack"))
            {
                health--;
            }
            
        }
    }

    void playerData()
    {
        //Putting the Current amount of Health into the Db all The Time
        insertThis = string.Format("UPDATE PlayerSaveData SET PlayerHealth='{0}'", health);
        dataManager.normalDbCommand(insertThis);
        //Updating the Lives in the Database
        putThisIn = string.Format("UPDATE PlayerSaveData SET PlayerLives='{0}'", lives);

        //If the player presses continue, the lives are reset to 3
        if (Continue.resetLives == true)
        {
            putThisIn = string.Format("UPDATE PlayerSaveData SET PlayerLives= 3", lives);
            Continue.resetLives = false;
        }

        dataManager.normalDbCommand(putThisIn);
        //Getting the Health and Lives from the Database
        dataManager.ReadingData("SELECT*FROM PlayerSaveData");
    }

    void updateLives()
    {
        putThisIn = string.Format("UPDATE PlayerSaveData SET PlayerLives='{0}'", lives);
    }

    void Update()
    {
        
        //This Is For Displaying the Amount of Health
        switch (health)
        {
            case 3: healthBarCharges[3].SetActive(false);
                    break;
            case 2: healthBarCharges[2].SetActive(false);
                healthBarCharges[3].SetActive(false);
                break;
            case 1: healthBarCharges[1].SetActive(false);
                healthBarCharges[2].SetActive(false);
                healthBarCharges[3].SetActive(false);
                break;
            case 4: foreach(var charge in healthBarCharges)
                {
                    charge.SetActive(true);
                }
                break;
            case 0: 
                lives--;
                updateLives();
                health = 4;
                break;
        }
        if(lives == -1)
        {
            lives = 0;
            gameOver = true;
        }else if(lives > 0)
        {
            gameOver = false;
        }
        //Displaying the Amount of Lives
        switch (lives)
        {
            case 3:
                {
                    LivesDisplay.text = "Lives: 3";
                }
                break;
            case 2:
                {
                    LivesDisplay.text = "Lives: 2";
                }
                break;
            case 1:
                {
                    LivesDisplay.text = "Last Life";
                }
                break;
            case 0:
                {
                    LivesDisplay.enabled = false;
                    SceneManager.LoadScene("GameOver");
                }
                break;
                
        }
        
    }
  
}
