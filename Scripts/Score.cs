using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	int m_Score = 0;

	public int M_Score {
		get {
			return m_Score;
		}
	}

	//This function increases the score variable by a certain amount. The amount changes depending upon what
	//just got destroyed, whether it be enemy1, enemy2 or the boss.
	public void ScoreAddition(int Score){
		m_Score = m_Score + Score;
	}
	
}
