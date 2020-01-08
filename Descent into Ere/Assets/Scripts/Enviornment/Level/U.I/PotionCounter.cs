using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PotionCounter : MonoBehaviour
{
    public Text CounterText;
    void Start(){
        CounterText.text = Inventory.NumberOfPotions.ToString();
    }
 void Update(){
     CounterText.text = Inventory.NumberOfPotions.ToString();
    if(Inventory.NumberOfPotions > 3){
        Inventory.NumberOfPotions = 3;
    }else if(Inventory.NumberOfPotions < 0){
        Inventory.NumberOfPotions = 0;
 }
 }
}