using UnityEngine;
using System.Collections;

public class BulletSelfDestruct : MonoBehaviour {

	public float m_timer = 5f;


	//This is a simple script which will destroy the gameObject after 5 seconds if it is still around. 
	//This stops it from moving infinitely.
	void Update () {
		m_timer -= Time.deltaTime;

		if (m_timer <= 0) {
			Destroy(gameObject);
		}
	}
}
