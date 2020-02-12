using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public static int health;
    public static int lives;
    public GameObject[] healthBarCharges;
    DbManager dataManager = DbManager.Instance;
    // Start is called before the first frame update
    void Start()
    {
        dataManager.ReadingData("SELECT*FROM PlayerSaveData");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            health--;
            string insertThis = string.Format("UPDATE PlayerSaveData SET PlayerHealth='{0}'", health);
            dataManager.normalDbCommand(insertThis);
        }
    }
   void Update()
    {
        dataManager.ReadingData("SELECT*FROM PlayerSaveData");
        healthBarCharges[health--].SetActive(true);
        if(health == 0)
        {
            healthBarCharges[health - 1].SetActive(false);
            lives--;
            health = 4;
        }
        if(health < 0)
        {
            health = 0;
        }
    }
}
