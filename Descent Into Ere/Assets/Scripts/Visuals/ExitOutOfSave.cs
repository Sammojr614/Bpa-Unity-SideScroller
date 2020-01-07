using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitOutOfSave : MonoBehaviour
{
    public GameObject X;
    public GameObject SizeBig;
    public GameObject SizeSmall;

    public GameObject Load;
    void OnMouseDown(){
        if(Input.GetMouseButtonDown(0)){
            SizeBig.SetActive(false);
            SizeSmall.SetActive(true);
            Load.SetActive(false);
            X.SetActive(false);
        }
    }
}
