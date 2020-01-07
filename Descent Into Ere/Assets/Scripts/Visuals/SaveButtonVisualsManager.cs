using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveButtonVisualsManager : MonoBehaviour
{
    public GameObject SizeSmall;
    public GameObject SizeBig;
    public GameObject LoadButton;
    public GameObject ExitoutofSaveButton;
    public GameObject Location;
    void Start(){
        SizeSmall.SetActive(true);
        SizeBig.SetActive(false);
        LoadButton.SetActive(false);
        ExitoutofSaveButton.SetActive(false);
        Location.SetActive(false);
    }
   void OnMouseDown(){
       if(Input.GetMouseButtonDown(0)){
           SizeBig.SetActive(true);
           SizeSmall.SetActive(false);
           LoadButton.SetActive(true);
           ExitoutofSaveButton.SetActive(true);
           Location.SetActive(true);
       }
   }
}
