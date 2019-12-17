using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealOnMouseOver : MonoBehaviour {
    public GameObject textToReveal;

   void Start()
    {
        textToReveal.SetActive(false);
    }

    void OnMouseEnter()
    {
        textToReveal.SetActive(true);
    }
        void OnMouseExit()
    {
        textToReveal.SetActive(false);
    }
}
