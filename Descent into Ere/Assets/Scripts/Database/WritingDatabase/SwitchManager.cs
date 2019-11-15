using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SwitchManager : MonoBehaviour {
public DbManager dataManager = DbManager.Instance;
public bool SwitchonList;

void Start(){
	
List<SwitchObject> switchList = new List<SwitchObject>();
				/* Switch List  */
//Adding things to the list
SwitchObject switchTest = new SwitchObject(0, "'Enemy Testing'", 0, "'PushButton'");
//Seeing if The Thing is ont the list
if(!switchList.Contains(switchTest)){
SwitchonList = false;
switchList.Add(switchTest);
}else{
SwitchonList = true;
}
	
}
}

public class SwitchObject: SwitchManager{
	 public static string SwitchLocation;
	public static  string SwitchType;

	public static int SwitchActiveCheck;
	public static int SwitchID;
	public static bool SwitchActive;
	string insertThis; 
	public SwitchObject(int switchID, string switchLocation, int switchActiveCheck, string switchType){
		SwitchLocation = switchLocation;
		SwitchType = switchType;
		SwitchID = switchID;
		SwitchActiveCheck = switchActiveCheck;
		insertThis = string.Format("INSERT INTO SwitchIndex(SwitchId,SwitchLocation, SwitchActive, SwitchType) VALUES({0},{1},{2},{3})", SwitchID,SwitchLocation, SwitchActiveCheck, SwitchType);
		if(SwitchonList == true){
			dataManager.dbCommand(dataManager.connectionString, insertThis);
		}
	}
}
