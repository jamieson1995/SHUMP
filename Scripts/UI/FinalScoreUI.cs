using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FinalScoreUI : MonoBehaviour {

	//This script sets the text for Score to the final score.

	[SerializeField]
	Text m_text;
	int m_Score;
	
	public GameObject m_World;
	
	public void FinalDeath() {
		m_Score = m_World.GetComponent<Score>().M_Score;
		m_text.text = "Final Score: " + m_Score;
		
	}
}
