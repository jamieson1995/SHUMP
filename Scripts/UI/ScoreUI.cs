using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ScoreUI : MonoBehaviour {

	//This script updates the score text to correctly display the current score.

	[SerializeField]
	Text m_text;

	int m_Score;

	public GameObject m_World;

	void Update () {

		m_Score = m_World.GetComponent<Score>().M_Score;
		m_text.text = "Score: " + m_Score;
			
	}
}
