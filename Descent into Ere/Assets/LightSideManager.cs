using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSideManager : MonoBehaviour {
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButton("Sprint")){
			for(var i = 0; i < 3; i++){
				transform.localScale -= new Vector3(10f,0f,0f);
			}
			
			
			Debug.Log(transform.localScale.x);
		}else{
			if(Input.GetButtonUp("Sprint")){
				while(LightBar.SprintLeft < 20){
				transform.localScale += new Vector3(10f,0f,0f);
			}
		}
		}
	}
}
