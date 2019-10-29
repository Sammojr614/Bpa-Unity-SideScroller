using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LightBar : MonoBehaviour {

Animator LighBarAnimator;
public static float SprintLeft;
public static  float MPdrain;
void Start(){
     SprintLeft = 20;
     LighBarAnimator = gameObject.GetComponent<Animator>();
      LighBarAnimator.SetFloat("Sprinting", 0.5f);
}
void Update(){
    if(Input.GetButton("Sprint")){
        SprintLeft--;
        LighBarAnimator.SetFloat("Sprinting", 0.0f);
    }else{
        if(Input.GetButtonUp("Sprint")){
            while(SprintLeft < 20){
                SprintLeft++;
                LighBarAnimator.SetFloat("Sprinting", 1.0f);
            }
           
        }
    }
    }
}

