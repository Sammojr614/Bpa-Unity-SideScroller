using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour {
	
	// Update is called once per frame
	void OnMouseDown () {
        if (Input.GetMouseButtonDown(0))
        {
            Application.Quit();
        }
	}
}
