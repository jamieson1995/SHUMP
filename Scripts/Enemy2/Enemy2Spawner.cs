using UnityEngine;
using System.Collections;

public class Enemy2Spawner : MonoBehaviour
{
	
	public GameObject m_Enemy2Prefab;
	GameObject m_enemy2Instance;	


	//This simply Instantiates the m_Enemy2Prefab with the correct position and rotation.
	public void SpawnEnemy(){
			m_enemy2Instance = (GameObject)Instantiate (m_Enemy2Prefab, transform.position, Quaternion.identity);
			m_enemy2Instance.transform.Rotate (0, 0, 90);
	}

}
