using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GetHighscore : MonoBehaviour {

	[SerializeField]
	Text m_text;

	int m_HighScore = PlayerPrefs.GetInt("Highscore");

	void Start () {
		m_text.text = "High Score: " + m_HighScore;
	}

}
