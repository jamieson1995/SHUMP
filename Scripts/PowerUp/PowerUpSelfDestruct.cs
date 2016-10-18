using UnityEngine;
using System.Collections;

public class PowerUpSelfDestruct : MonoBehaviour {

	//This script simply destroys the gameObject after 5 seconds so that it doesn't carry on moving
	//to the left infinitely.

	public float m_timer = 5f;
	
	void Update () {
		m_timer -= Time.deltaTime;
		
		if (m_timer <= 0) {
			Destroy(gameObject);
		}
	}
}
