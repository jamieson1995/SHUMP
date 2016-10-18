using UnityEngine;
using System.Collections;

public class DontDestroy : MonoBehaviour {

	//This script allows gameObjects to stay between scene changes, this is only so that the menu
	//background sound can stay through the instruction scenes.

	void Start () {
		DontDestroyOnLoad (gameObject);
	}

}
