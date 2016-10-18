using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {

	//This simple script has a timer counting down from 0.25 to 0, at which point it will instantiate
	//a m_bulletPrefab in the correct position, taking into account the m_bulletOffset.

	//This offset allows the bullet to fire from the front of the player instead of on top of it.
	public Vector3 m_bulletOffset = new Vector3(0, 0.5f, 0);
	public GameObject m_bulletPrefab;

    public float m_fireDelay = 0.25f;
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
