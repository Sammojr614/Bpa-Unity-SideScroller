using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataMgr
{
    private static DataMgr getData;
    private DataMgr()
    {

    }
    public static DataMgr Instance
    {
        get
        {
            if(getData == null)
            {
                getData = new DataMgr();
            }
            return getData;
        }
    }
    public int TimesPlayed;
    public string location;
    public int Playerhealth;
    public int PlayerLives;
    public int Playercurrency;
   

}
