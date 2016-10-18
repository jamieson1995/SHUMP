using UnityEngine;
using System.Collections;

public class LoadOnClickUI : MonoBehaviour {

	//This is used so my buttons can change from scene to scene correctly.

	public GameObject m_LoadingScreen;
	public GameObject m_PauseScreen;

	
	public void LoadScene(int Level){

		//If the scene goes to the main game scene, scene 1, then the MenuBackgroundMusic(Clone) is
		//destroyed, this is required because it contains a can't destroy function which allows the background
		//sound to continue through the menu and the instruction screens, but the menu background sound is not
		//wanted in the main game.
		if (Level == 1) {
			Destroy (GameObject.Find ("MenuBackgroundMusic(Clone)"));
			//This next line means the if there is a delay in loading the next scene, the user will get a loading UI screen
			//while they wait.
			m_LoadingScreen.SetActive(true);
		}
		Application.LoadLevel (Level);
	}

	//This function means the if there is a delay in loading the next scene, the user will get a loading UI screen
	//while they wait.
	public void Loading(){
		m_LoadingScreen.SetActive(true);
	}

	public void Pause(){
		Time.timeScale = 0;
		m_PauseScreen.gameObject.SetActive (true);
	}

	public void Resume(){
		Time.timeScale = 1;
		m_PauseScreen.gameObject.SetActive (false);
	}

	public void Exit(){
		Application.Quit();
	}
}
