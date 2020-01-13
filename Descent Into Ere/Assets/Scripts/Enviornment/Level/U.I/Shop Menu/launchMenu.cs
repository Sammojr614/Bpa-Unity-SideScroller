using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launchMenu : MonoBehaviour
{
   public GameObject ShopMenu;
   public static bool  shopMenuOpen;
   void OnMouseDown(){
       if(Input.GetMouseButtonDown(0)){
           ShopMenu.SetActive(true);
           shopMenuOpen = true;
       }
   }
}
