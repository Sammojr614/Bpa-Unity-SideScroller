using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Potion : MonoBehaviour {

    public Animator health;

    public GameObject useButton;
    public Text CantUseText;
    void Start(){
        CantUseText.enabled = false;
    }
    void Update(){
        if (Input.GetMouseButtonDown(0) && Inventory.NumberOfPotions <= 0) {
                CantUseText.enabled = true;
                useButton.SetActive(false);
            }
            if(Input.GetMouseButtonUp(0)){
                useButton.SetActive(true);
                CantUseText.enabled = false;
            }
    }
    public void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
				PlayerHealth.Heal (health);
				Inventory.NumberOfItems--;
				Inventory.NumberOfPotions--;
                
        }
    }

}
