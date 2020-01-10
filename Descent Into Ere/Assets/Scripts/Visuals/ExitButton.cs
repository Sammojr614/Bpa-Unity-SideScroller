using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
  public GameObject[] Stuff;
  public GameObject ExitButtonGameObject;
  public GameObject[] TurnBackOn;
  
  void OnMouseDown(){
      if(Input.GetMouseButtonDown(0)){
          foreach(GameObject things in Stuff){
             things.SetActive(false);
          }
          foreach(GameObject off in TurnBackOn){
              off.SetActive(true);
          }
          ExitButtonGameObject.SetActive(false);
      }
  }
}
