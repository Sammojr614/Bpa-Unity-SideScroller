using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMgr : MonoBehaviour
{
    DbManager dbMgr = DbManager.Instance;
    public static int LevelsComplete;
    bool OzulDreamComplete;
    bool LucidComplete;
    bool NightmareComplete;

    private void Start()
    {
        dbMgr.LevelData("SELECT*FROM LevelIndex");
    }
    // Update is called once per frame
    void Update()
    {
        if(LevelsComplete == 1)
        {
            OzulDreamComplete = true;
            LucidComplete = false;
            LucidComplete = false;
        }else if (LevelsComplete == 2)
        {
            OzulDreamComplete = true;
            LucidComplete = true;
            NightmareComplete = false;
        }else if(LevelsComplete == 3)
        {
            OzulDreamComplete = true;
            LucidComplete = true;
            NightmareComplete = true;
        }
    }
}
