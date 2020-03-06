using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenThingy : MonoBehaviour
{
    public Button ButtonPressed;
    public GameObject ThingToOpen;
    
   
    // Start is called before the first frame update
    void Start()
    {
        ThingToOpen.SetActive(false);
        ButtonPressed.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        ThingToOpen.SetActive(true);
        
    }

}
