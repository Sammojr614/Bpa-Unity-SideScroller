using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public static int health;
    public static int lives;
    public Text LivesDisplay;
    public GameObject[] healthBarCharges;
    DbManager dataManager = DbManager.Instance;
    // Start is called before the first frame update
    void Start()
    {
        dataManager.ReadingData("SELECT*FROM PlayerSaveData");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            health--;
        }
    }
    void Update()
    {
        //Putting the Current amount of Health into the Db all The Time
        string insertThis = string.Format("UPDATE PlayerSaveData SET PlayerHealth='{0}'", health);
        dataManager.normalDbCommand(insertThis);
        //Updating the Lives in the Database
        string putThisIn = string.Format("UPDATE PlayerSaveData SET PlayerLives='{0}'", lives);
        dataManager.normalDbCommand(putThisIn);
        //Getting the Health and Lives from the Database
        dataManager.ReadingData("SELECT*FROM PlayerSaveData");
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
        }
        if(lives > 0)
        {
            lives--;
        }
        //Displaying the Amount of Lives
        switch (lives)
        {
            case 3: LivesDisplay.text = "Lives: 3";
                break;
            case 2: LivesDisplay.text = "Lives: 2";
                break;
            case 1: LivesDisplay.text = "Last Life";
                break;
            case 0: LivesDisplay.enabled = false;
                break;
        }
    }
  
}
