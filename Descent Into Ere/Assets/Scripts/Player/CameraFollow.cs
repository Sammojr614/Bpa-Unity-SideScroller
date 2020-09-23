using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CameraFollow : MonoBehaviour
{
    //Camera Bounds
    [SerializeField] private float Xmin;
    [SerializeField] private float Xmax;
    [SerializeField] private float Ymin;
    [SerializeField] private float Ymax;
  

    //Player

    [SerializeField] private Transform Player;
    

    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
        
    }

    void FollowPlayer()
    {
        float x = Mathf.Clamp(Player.transform.position.x, Xmin, Xmax);
        float y = Mathf.Clamp(Player.transform.position.y, Ymin, Ymax);
        gameObject.transform.position = new Vector3(x, y, gameObject.transform.position.z);
    }
}
