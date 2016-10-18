using UnityEngine;
using System.Collections;

public class BossSpawner : MonoBehaviour {

	public GameObject m_BossPrefab;
	GameObject m_BossInstance;

	public GameObject m_WeakPointPrefab;
	GameObject m_WeakPointInstance;

	public GameObject m_BossTurretPrefab;
	GameObject m_BossTurrentInstance1;
	GameObject m_BossTurrentInstance2;

	public GameObject m_BossNotice;

	//These offsets allow the child objects to instantiate at the desired location instead of where the parent is.
	Vector3 m_OffsetWP = new Vector3(-2.8f, 0f, -0.1f);
	Vector3 m_OffsetTurret1 = new Vector3(-3.2f,  2.1f, -0.1f);
	Vector3 m_OffsetTurret2 = new Vector3(-3.2f, -2.1f, -0.1f);

	//This code instantiates the boss and its children in the correct places with the correct rotations.
	public void SpawnEnemy(){

		m_BossInstance = (GameObject)Instantiate (m_BossPrefab, transform.position, Quaternion.identity);
		m_BossInstance.transform.Rotate (0, 0, 90);

		m_WeakPointInstance = (GameObject)Instantiate (m_WeakPointPrefab, transform.position + m_OffsetWP, Quaternion.identity);
		m_WeakPointInstance.transform.SetParent (m_BossInstance.transform, transform);

		m_BossTurrentInstance1 = (GameObject)Instantiate (m_BossTurretPrefab, transform.position + m_OffsetTurret1, Quaternion.identity);
		m_BossTurrentInstance1.transform.SetParent (m_BossInstance.transform, transform);
		m_BossTurrentInstance1.transform.Rotate (0, 0, 97);

		m_BossTurrentInstance2 = (GameObject)Instantiate (m_BossTurretPrefab, transform.position + m_OffsetTurret2, Quaternion.identity);
		m_BossTurrentInstance2.transform.SetParent (m_BossInstance.transform, transform);
		m_BossTurrentInstance2.transform.Rotate (0, 0, 83);

		//This sets a UI element to be active. This will happen as soon as the boss instantiates.
		m_BossNotice.gameObject.SetActive (true);

	}
}
