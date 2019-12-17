using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopTesting : MonoBehaviour {
DbManager dataManager = DbManager.Instance;
	// Use this for initialization
	void Start () {
		dataManager.PlayerLocation = "'ShopTesting'";
	}
}
