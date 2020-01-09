using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PotionButton : MonoBehaviour
{
   public Text CantUseText;
   public SpriteRenderer PotionButtonGameObject;
   public Text UseButtonText;
  void Update(){
      if(Input.GetMouseButtonDown(0)){
          if(Inventory.NumberOfPotions >= 0){
              CantUseText.enabled = true;
              PotionButtonGameObject.enabled = false;
              UseButtonText.enabled = false;
          }
      }
      if(Input.GetMouseButtonUp(0)){
          CantUseText.enabled = false;
          PotionButtonGameObject.enabled = true;
          UseButtonText.enabled = true;
      }
  }
}
