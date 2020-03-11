using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Delete : MonoBehaviour
{
    public Button EraseButton;
    public GameObject EraseDialog;
    public Button YesButton;
    public Button NoButton;
    void Start()
    {
        EraseDialog.SetActive(false);
        EraseButton.onClick.AddListener(OpenOnClick);
        NoButton.onClick.AddListener(CloseOnClick);
        YesButton.onClick.AddListener(CloseOnClick);
    }
    void OpenOnClick()
    {
        EraseDialog.SetActive(true);
    }
    void CloseOnClick()
    {
        EraseDialog.SetActive(false);
    }

   
}
