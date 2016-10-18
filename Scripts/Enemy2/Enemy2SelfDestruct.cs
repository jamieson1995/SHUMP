using UnityEngine;
using System.Collections;

public class Enemy2SelfDestruct : MonoBehaviour {
	
	public float m_timer = 7f;

	//This is a simple script which will destroy the gameObject after 7 seconds if it is still around. 
	//This stops it from moving left infinitely.
	void Update () {
		m_timer -= Time.deltaTime;
		
		if (m_timer <= 0) {
			Destroy(gameObject);
		}
	}
}
