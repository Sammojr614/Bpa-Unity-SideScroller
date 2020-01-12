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
        background.GetComponent<Renderer>().material.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        changeTime += Time.deltaTime * 0.3f;

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

        if(changeTime >= 0.3f)
        {
            background.GetComponent<Renderer>().material.color = Color.green;
        }

        if(changeTime >= 0.4f)
        {
            background.GetComponent<Renderer>().material.color = Color.yellow;
        }

        if(changeTime >= 0.5f)
        {
            background.GetComponent<Renderer>().material.color = Color.cyan;
        }

        if(changeTime >= 0.6f)
        {
            background.GetComponent<Renderer>().material.color = Color.grey;
        }

        if(changeTime >= 0.7f)
        {
            background.GetComponent<Renderer>().material.color = Color.grey;
        }

        if(changeTime >= 0.8f)
        {
            background.GetComponent<Renderer>().material.color = Color.magenta;
        }

        if(changeTime >= 0.9f)
        {
            background.GetComponent<Renderer>().material.color = Color.black;
        }

    }
}
