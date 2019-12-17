﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    private GameObject player;

    /* Minimum and maximum x and y values
     * For the axes, these restrict the camera
     * From going out of bounds
     */
    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;

	void Start () {
        //Identifies the player
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	void Update () {
        //Makes the camera change position, as the player moves
        float x = Mathf.Clamp(player.transform.position.x, xMin, xMax);
        float y = Mathf.Clamp(player.transform.position.y, yMin, yMax);
        gameObject.transform.position = new Vector3(x, y, gameObject.transform.position.z);


    }
}
