using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour {

    public Animator health;

    public GameObject useButton;
    
   
    void Update(){
        if (Input.GetMouseButtonDown(0) && Inventory.NumberOfPotions > 0)
        {
				PlayerHealth.Heal (health);
				Inventory.NumberOfItems--;
				Inventory.NumberOfPotions--;
                
        }
    }
}   