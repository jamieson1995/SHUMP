using UnityEngine;
using System.Collections;

public class EnemyShooting : MonoBehaviour {

	//This script allows the bullet prefab to instantiate when the enemy fires.

	public Vector3 m_bulletOffset = new Vector3(0, 1f, 0);
	public GameObject m_bulletPrefab;
	
	public float m_fireDelay = 0.75f;
	float m_cooldownTimer = 0;
	
	void Update () {
		m_cooldownTimer -= Time.deltaTime;
		
		if ( m_cooldownTimer <= 0){
			m_cooldownTimer = m_fireDelay;

			Vector3 offset = transform.rotation * m_bulletOffset;
			
			Instantiate(m_bulletPrefab, transform.position + offset, transform.rotation);
		}
	}
}
