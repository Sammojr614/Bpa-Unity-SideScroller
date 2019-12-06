using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDreamPt2 : MonoBehaviour {
DbManager dataManager = DbManager.Instance;
	// Use this for initialization
	void Start () {
	dataManager.PlayerLocation = "'PlayerDreamPt2'";
	}
}
