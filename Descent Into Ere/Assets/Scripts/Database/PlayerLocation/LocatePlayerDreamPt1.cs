﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocatePlayerDreamPt1 : MonoBehaviour
{
    DbManager dbMgr = DbManager.Instance;
    private void Start()
    {
        dbMgr.PlayerLocation = "PlayerDreamPt1";
        string location = string.Format("UPDATE PlayerSaveData SET PlayerLocation = '{0}'", dbMgr.PlayerLocation);
        dbMgr.normalDbCommand(location);
    }
}
