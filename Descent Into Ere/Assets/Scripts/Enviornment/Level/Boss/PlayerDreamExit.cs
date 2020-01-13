using UnityEngine;
using System.Collections;

public class PlayerDreamExit : MonoBehaviour
{

    public GameObject exit;

    void Update()
    {
        if(ExecutionerHealth.bossDestroyed == true)
        {
            exit.SetActive(true);
        }
    }
}
