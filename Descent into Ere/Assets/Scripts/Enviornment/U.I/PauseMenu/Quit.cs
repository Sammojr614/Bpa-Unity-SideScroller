using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour {
	
	//Method checks when quit is clicked
	void OnMouseDown () {
        /* if this Button is Clicked it Goes back the title Screen */
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Title");
        }
	}
}
