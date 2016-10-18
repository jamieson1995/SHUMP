using UnityEngine;
using System.Collections;

public class MoveForward : MonoBehaviour {

	//This is a simply script that a lot of my gameObjects have. It simply moves a gameObject forward
	//at a given speed which can be changed in the editor.

	public float m_MaxSpeed = 10f;

	Vector3 m_pos;
	Vector3 m_velocity;

	void Update () {
		m_pos = transform.position;

		m_velocity = new Vector3(0, m_MaxSpeed * Time.deltaTime, 0);

		m_pos += transform.rotation*m_velocity;

		transform.position = m_pos;
	}
}
