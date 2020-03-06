using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class Health : MonoBehaviour
{
    DataMgr data = DataMgr.Instance;
    public static int health;
    public static int lives;
    public GameObject[] healthCharges;
    public Text livesDisplay;

    private void Update()
    {
        string DmgCheck = File.ReadAllText(Application.dataPath + "/Database/PlayerSaveData.json");
        DataMgr loadDmg = JsonUtility.FromJson<DataMgr>(DmgCheck);
        health = loadDmg.Playerhealth;
        lives = loadDmg.PlayerLives;
        livesDisplay.text ="Lives: " +  loadDmg.PlayerLives.ToString();
        switch (health)
        {
            case 4:
                foreach(GameObject charge in healthCharges)
                {
                    charge.SetActive(true);
                }
                break;
            case 3:
                healthCharges[0].SetActive(false);
                break;
            case 2:
                healthCharges[1].SetActive(false);
                break;
            case 1: healthCharges[2].SetActive(false);
                break;
            case 0: foreach(GameObject charges in healthCharges)
                {
                    charges.SetActive(false);
                }
                lives--;
                health = 4;
                break;
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            health--;
            string json = JsonUtility.ToJson(data);
            File.WriteAllText(Application.dataPath + "/Database/PlayerSaveData.json", json);
        }
    }

}
