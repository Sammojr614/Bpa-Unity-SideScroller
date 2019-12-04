using System;
using UnityEngine;
using System.Collections.Generic;

public class CrystalCounter: MonoBehaviour{
	public GameObject[] FirstDidget;
	public GameObject[] SecondDidget;
	public static int FirstDigt;
	public static  int SecndDigt;
	public static int ThirdDiget;

	void Start(){
		
	}
	void Update(){
		//First Didget Deactivation, At least the ones not needed on Scene Load
		foreach (var firstNumber in FirstDidget) {
			for (var i = 0; i < FirstDidget.Length; i++) {
				FirstDidget [i].SetActive (false);
			}
		}
		//When Changing Scenes Disabling the Numbers that aren't needed
		foreach (var secondNumber in SecondDidget) {
			for(var i = 0; i < SecondDidget.Length; i++){
				SecondDidget [i].SetActive (false);
			}
		}
		//Setting the Numbers
		//If the Ones Place is Bigger than 9
		if (ThirdDiget > 9) {
			ThirdDiget = 0;
			SecndDigt++;
			//If the Ones Place is Less Than 0
		}else if(ThirdDiget < 0){
			ThirdDiget = 9;
			if(SecndDigt > 0){
			SecndDigt--;
			}
		}
		//if the Tens Place is Greater then 9
		if (SecndDigt >= 9) {
			SecndDigt = 0;
			FirstDigt++;
			//if the Tens Place is Less than 0
		}else if(SecndDigt < 0){
			SecndDigt = 9;
			if(FirstDigt > 0){ 
			FirstDigt--;
			}
			
		}
		if (FirstDigt >= 9) {
			ThirdDiget = 9;
		}else if(FirstDigt < 0){
			FirstDigt = 0;
		}
		if (FirstDigt < 1) {
			SecondDidget [ThirdDiget].SetActive (true);
			FirstDidget [SecndDigt].SetActive (true);
		}
	}
}