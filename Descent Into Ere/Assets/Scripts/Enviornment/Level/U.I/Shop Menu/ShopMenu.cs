using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopMenu : MonoBehaviour
{
    public GameObject ShopMenuGame;
    public GameObject CloseButton;
    public GameObject[] ShopStock;
  void Start(){
      ShopMenuGame.SetActive(false);
      CloseButton.SetActive(false);
      foreach(GameObject item in ShopStock){
          item.SetActive(false);
      }
  }
  void Update(){
      if(launchMenu.shopMenuOpen == true){
          CloseButton.SetActive(true);
          foreach(GameObject item in ShopStock){
              item.SetActive(true);
          }
      }
     if(ShopMenuGame.active == false){
         CloseButton.SetActive(false);
         foreach(GameObject item in ShopStock){
             item.SetActive(false);
         }
     }
  }
}
