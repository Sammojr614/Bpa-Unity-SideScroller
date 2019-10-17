using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour {
	
	//Method checks when quit is clicked
	void OnMouseDown () {
        /*If the quit button is clicked,
         * The game will close
         */
        if (Input.GetMouseButtonDown(0))
        {
            Application.Quit();
        }
	}
}
