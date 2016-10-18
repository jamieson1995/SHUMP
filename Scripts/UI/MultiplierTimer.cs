using UnityEngine;
using System.Collections;

public class MultiplierTimer : MonoBehaviour {

	//This script has a timer set for 30 seconds so that every 30 seconds the multiplier increases by 1.

	public float m_MultiplierTimerDelay = 30f;
	float m_CurrentMultiplierTimer = 30f;

	public float M_CurrentMultiplierTimer {
		get {
			return m_CurrentMultiplierTimer;
		}
		set {
			m_CurrentMultiplierTimer = value;
		}
	}

	int multiplierValue = 1;

	public int MultiplierValue {
		get {
			return multiplierValue;
		}
		set {
			multiplierValue = value;
		}
	}	

	void MultiplierAddition(){
		multiplierValue = multiplierValue + 1;
	}


	void Update () {
		
		if (m_CurrentMultiplierTimer <= 1) {
			
			MultiplierAddition();
			m_CurrentMultiplierTimer = m_MultiplierTimerDelay;
		}
		
		if (m_CurrentMultiplierTimer > 0) {
			
			m_CurrentMultiplierTimer -= Time.deltaTime;
		}
	}
}
