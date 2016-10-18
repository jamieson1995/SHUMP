using UnityEngine;
using System.Collections;

public class Lives : MonoBehaviour {

	public GameObject m_DeathScreen;
	public GameObject m_FinalDeathUI;

	public int m_Lives = 3;

	int m_Highscore;
	int m_Score;

	//When this function is run, the player's lives decrease by 1. If the lives is now less than 0,
	//the DeathScreenUI is set to active, the FinalDeath() function is run, the time scale becomes 0 and
	//and the final score is set. If the final score is greater than that saved score, which is saved
	//in the PlayerPrefs as Highscore, then the Highscore is updated to the final score.

	public void PlayerHit(){

		m_Lives = m_Lives - 1;

		if (m_Lives < 0) {
			m_DeathScreen.gameObject.SetActive (true);
			m_FinalDeathUI.GetComponent<FinalScoreUI>().FinalDeath();
			Time.timeScale = 0;
			m_Score = gameObject.GetComponent<Score>().M_Score;
			if (m_Score > m_Highscore){
				PlayerPrefs.SetInt("Highscore", m_Score);
			}
		}
	}

	void Start(){
		m_Highscore = PlayerPrefs.GetInt ("Highscore");
	}

}
