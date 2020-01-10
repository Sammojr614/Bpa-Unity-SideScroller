using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevSceneButtons : MonoBehaviour
{
   public GameObject SmallButton;
   public GameObject BigScreen;
   public GameObject ExitButton;
   void Start(){
       SmallButton.SetActive(true);
       BigScreen.SetActive(false);
       ExitButton.SetActive(false);
   }
   void OnMouseDown(){
       if(Input.GetMouseButtonDown(0)){
           SmallButton.SetActive(false);
           BigScreen.SetActive(true);
           ExitButton.SetActive(true);
       }
   }
}
