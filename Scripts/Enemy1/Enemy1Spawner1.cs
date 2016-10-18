using UnityEngine;
using System.Collections;

public class Enemy1Spawner1 : MonoBehaviour
{
	
	public GameObject m_Enemy1PreFab;
	GameObject m_enemy1Instance;
	
	//When this code runs, the m_Enemy1PreFab is instantiated in the correct position with the correct roatation.
	public void SpawnEnemy()
	{
		m_enemy1Instance = (GameObject)Instantiate(m_Enemy1PreFab, transform.position, Quaternion.identity);
		m_enemy1Instance.transform.Rotate(0, 0, 90);
	}
	
	
}
