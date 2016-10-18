using UnityEngine;
using System.Collections;

public class Enemy1Behaviour : MonoBehaviour {

    public float m_MovementSpeed = 3f;


	void Update () {

        Vector3 pos = transform.position;

		pos.x -= m_MovementSpeed * Time.deltaTime;

        transform.position = pos;
        
	}
}
