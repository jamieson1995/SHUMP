using UnityEngine;
using System.Collections;

public class LoadSound : MonoBehaviour {

	//This is required so that the MenuBackgroundMusic Prefab can be instantiated when the Menu loads, 
	//but only if it is not already present.
	//This is required because the MenuBackgroundMusic Prefab contains a script that allows it to
	//not be detroyed when the scene changes. The problem is that if there is no check to see if it already
	//exsits then if the menu is loaded twice in 1 session, such as going to the instructions and back, 
	//then a second one will instantiate with its own background music.

	public GameObject m_BackgroundMusicPrefab;

	void Start () {
		if (GameObject.Find ("MenuBackgroundMusic(Clone)") == null) {
			Instantiate(m_BackgroundMusicPrefab, transform.position, Quaternion.identity);
		}
	}

}
