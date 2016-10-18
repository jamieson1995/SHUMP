using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour {

	public float m_ScrollSpeed = 0.5f;


	//This is what scrolls the background image. (Tutorial used: https://www.youtube.com/watch?v=HrDxnMI7pCc)
	void Update () {
		Vector3 m_offset = new Vector3 (Time.time * m_ScrollSpeed, 0, 0);
		GetComponent<Renderer>().material.mainTextureOffset = m_offset;
	}
}
