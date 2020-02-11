using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseThingy : MonoBehaviour
{
    public Button ButtonPressed;
    public GameObject CloseThis;
    // Start is called before the first frame update
    void Start()
    {
        ButtonPressed.onClick.AddListener(taskOnClick);
    }

    void taskOnClick()
    {
        CloseThis.SetActive(false);
    }
}
