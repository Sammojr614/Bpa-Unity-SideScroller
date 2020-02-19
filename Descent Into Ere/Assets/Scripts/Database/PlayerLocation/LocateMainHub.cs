using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocateMainHub : MonoBehaviour
{
    DbManager dbMgr = DbManager.Instance;
    // Start is called before the first frame update
    void Start()
    {
        dbMgr.PlayerLocation = "MainHub";
        string location = string.Format("UPDATE PlayerSaveData SET PlayerLocation = '{0}'", dbMgr.PlayerLocation);
        dbMgr.normalDbCommand(location);
    }
}
