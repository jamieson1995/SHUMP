using UnityEngine;
using System.Collections;

public class BossBehaviour : MonoBehaviour {

	public float m_MovementSpeed = 1f; 

	void Update () {

		if (transform.position.x >= 7 ){

			Vector3 pos = transform.position;
		
			pos.x -= m_MovementSpeed * Time.deltaTime;
		
			transform.position = pos;
	}
		
	}
}
