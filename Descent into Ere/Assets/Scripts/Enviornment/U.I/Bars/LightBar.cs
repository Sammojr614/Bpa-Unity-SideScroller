using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LightBar : MonoBehaviour {

public static float SprintLeft;

void Start(){
     SprintLeft = 20; 
}
void Update(){
    if(Input.GetButton("Sprint")){
        SprintLeft--;
    }else{
        if(Input.GetButtonUp("Sprint")){
            while(SprintLeft < 20){
                SprintLeft++;
            }
        }
    }
}
}

