using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resume : MonoBehaviour {

    public static bool gameResumed;

	void Update () {
        if(Input.GetMouseButton(0)){
            Debug.Log(gameResumed = true);
            gameResumed = true;
        }
	}
}
