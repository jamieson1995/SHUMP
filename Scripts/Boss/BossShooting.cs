using UnityEngine;
using System.Collections;

public class BossShooting : MonoBehaviour {

	//Sets the rocket to begin in front of the gun not on top of it.
	public Vector3 m_RocketOffset = new Vector3(0, 2.8f, 0);

	public GameObject m_RocketPrefab;

	GameObject m_Player;

	//m_firedelay is shots fired per second.
	public float m_fireDelay = 0.75f;
	float m_cooldownTimer = 0;

	void Update () {

		//This finds the current player instance.
		m_Player = GameObject.Find ("Player(Clone)");

		//Only runs if the player is alive.
		if (m_Player != null) {
			Rotate_To_Player();
		}

		m_cooldownTimer -= Time.deltaTime;

		//This code is the timer code so that the rocket instantiates only at the end of the timer.
		if ( m_cooldownTimer <= 0){
			m_cooldownTimer = m_fireDelay;

			Vector3 offset = transform.rotation * m_RocketOffset;

			Instantiate(m_RocketPrefab, transform.position + offset, transform.rotation);
		}
	}

	//This code rotates the turret so it faces the player's position.
	void Rotate_To_Player(){
		Vector3 pos = transform.position;
		Vector3 dir = m_Player.transform.position - pos;

		Quaternion rotation = Quaternion.LookRotation (Vector3.forward, dir);
		transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Time.deltaTime * 5f);
	}
}
