using UnityEngine;
using System.Collections;

public class BossNoticeSelfDestructUI : MonoBehaviour {

	//This script allows the boss notice to only remain active for 5 seconds.

	public float m_TimerDelay = 5f;
	float m_CurrentTimer = 5f;
	
	void Update () {
		if (gameObject.activeSelf == true) {
			m_CurrentTimer -= Time.deltaTime;
		
			if (m_CurrentTimer <= 0) {
				gameObject.SetActive (false);
				m_CurrentTimer = m_TimerDelay;
			}
		}

	}
}
