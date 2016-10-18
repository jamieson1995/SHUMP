using UnityEngine;
using System.Collections;

public class PowerUpBehaviour : MonoBehaviour {

	public float m_MovementSpeed = 1.5f;
	
	Vector3 m_pos;

	void Update () {
		
		m_pos = transform.position;
		
		m_pos.x -= m_MovementSpeed * Time.deltaTime;
		
		transform.position = m_pos;
		
	}
}
