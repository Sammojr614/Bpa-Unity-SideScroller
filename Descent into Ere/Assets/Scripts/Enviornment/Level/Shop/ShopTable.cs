using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopTable : MonoBehaviour {
	DbManager dataManager = DbManager.Instance;
	public GameObject PressUp;
	public static int amountOfPlayerCurrency;
	public static bool ShopContainsPotion;
	public static string NameOfItem;
	public static int CostOfItem;
	public static int NumberOfItems;

	void Start(){
		PressUp.SetActive(false);
	}
	void OnTriggerEnter2D(Collider2D collider){
		if(collider.CompareTag("Player")){
			PressUp.SetActive(true);
		}
		
	}
	void OnTriggerExit2D(Collider2D collider){
		if(collider.CompareTag("Player")){
			PressUp.SetActive(false);
		}
	}
	
}
