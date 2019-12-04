using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    public int enemyHealth;
    public GameObject enemy;
	
	// Update is called once per frame
	void Update () {
		if(enemyHealth <= 0)
        {
            DestroyObject(enemy);
        }
    }
}
