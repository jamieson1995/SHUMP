using UnityEngine;
using System.Collections;

public class SetTimeScale : MonoBehaviour {

	//This runs once at the start of the games scene. It is required because when a player
	//loses, the time scale is set to 0 so that the final score screen can be displayed.
	//If the player decided to restart the game from the menu the timescale would still be 0.
	//The script solves that problem.

	void Start () {
		Time.timeScale = 1;
	}

}
