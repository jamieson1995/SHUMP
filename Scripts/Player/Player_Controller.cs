using UnityEngine;
using System.Collections;

public class Player_Controller : MonoBehaviour {

	//This script controls the movement of the player.

    Vector3 m_ShipPosition;

    public float m_moveSpeed = 0.1f;

	Touch m_Touch;

	//This vector3 finds the center position of the screen, this is required so that I can set
	//the player to move only if the touch occurs on the left hand side of the screen.

	Vector3 m_CameraCenter = Camera.main.WorldToScreenPoint (new Vector3 (0.5f, 0.5f, 0f));
		
	void Update () {

		m_Touch = Input.GetTouch(0);

		//This is a simple statement which take the touch input converts it to a worldpoint, 
		//the the player's ship will lerp to the position at a rate of 0.1.
		if (m_Touch.position.x <= m_CameraCenter.x){
			m_ShipPosition = new Vector3 (100, m_Touch.position.y, 0);
			m_ShipPosition = Camera.main.ScreenToWorldPoint (m_ShipPosition);
			transform.position = Vector2.Lerp (transform.position, m_ShipPosition, m_moveSpeed);
		}
	}
}
