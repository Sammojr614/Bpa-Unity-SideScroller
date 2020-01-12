using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundColor : MonoBehaviour
{

    //Background
    public GameObject background;

    //changeTime
    private float changeTime;

    // changeTime equals zero on start
    void Start()
    {
        changeTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        changeTime += Time.deltaTime;

        if(changeTime >= 1f)
        {
            changeTime = 0f;
        }

        if(changeTime >= 0.1f)
        {
            background.GetComponent<Renderer>().material.color = Color.blue;
        }

        if(changeTime >= 0.2f)
        {
            background.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
