using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public static int EHealth;
    public string EnemyType;
    public GameObject Enemy;
    // Start is called before the first frame update
    void Start()
    {
        Enemy.SetActive(true);
        if (EnemyType == "FirstEnemy")
        {
            EHealth = 2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(EHealth == 0)
        {
            Enemy.SetActive(false);
        }
    }
}
