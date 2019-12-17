using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LucidPt2 : MonoBehaviour {
DbManager dataManager = DbManager.Instance;
	// Use this for initialization
	void Start () {
		dataManager.PlayerLocation = "'LucidPart2'";
	}
}
