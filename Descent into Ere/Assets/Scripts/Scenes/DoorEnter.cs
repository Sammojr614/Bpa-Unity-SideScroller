using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DoorEnter : MonoBehaviour {

    [SerializeField] private string newLevel;


    private void Update()
    {
        if (Input.GetButtonDown("EnterDoor"))
        {
            SceneManager.LoadScene(newLevel);
        }
    }

}

