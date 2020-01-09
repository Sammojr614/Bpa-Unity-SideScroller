using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevSceneButtons : MonoBehaviour
{
    public GameObject SmallButton;
    public GameObject BigScreen;
    public GameObject SmallinButton;
    void Start(){
        SmallButton.SetActive(true);
        BigScreen.SetActive(false);
        SmallButton.SetActive(false);
    }
    void OnMouseDown(){
        if(Input.GetMouseButtonDown(0)){
            BigScreen.SetActive(true);
            SmallButton.SetActive(false);
            SmallinButton.SetActive(true);
        }
    }
}
