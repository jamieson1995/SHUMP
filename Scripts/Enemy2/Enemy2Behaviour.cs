using UnityEngine;
using System.Collections;

public class Enemy2Behaviour : MonoBehaviour {

	//This this the most complex enemy movement I have implimentated.

	public float m_MovementSpeed = 0.5f;
	public float m_frequency  = 20.0f;
	public float m_magnitude = 0.5f;

	Vector3 m_pos;
	Vector3 m_axis;

	void Start(){
		m_pos = transform.position;
		//Vector3.up = (0,1,0)
		m_axis = Vector3.up;
	}

	//Every frame the position changes based upon a cos wave with a certain frequency and magnitude. 4
	//The larger the frequency, the more quickly the object will complete one wavelength
	//The larger the magnitude, the larger the amplitude of the wave.
	void Update () {
		
		m_pos -= Vector3.right * m_MovementSpeed * Time.deltaTime;
		
		transform.position = m_pos + m_axis * Mathf.Cos(Time.time * m_frequency) * m_magnitude;
	
	}
}
