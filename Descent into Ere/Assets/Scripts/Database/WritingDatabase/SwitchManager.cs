using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SwitchManager : MonoBehaviour {
DbManager dataManager = DbManager.Instance;

void Start(){
	
List<SwitchObject> switchList = new List<SwitchObject>();
SwitchObject switchTest = new SwitchObject(0, "'Enemy Testing'", 0, "'PushButton'");
if(!switchList.Contains(switchTest)){
switchList.Add(switchTest);
}
}
}
public class SwitchObject{
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
	}
}
