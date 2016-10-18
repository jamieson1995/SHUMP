using UnityEngine;
using System.Collections;

public class BossSpawnerTimer : MonoBehaviour {


	//This script is a simple timer, which counts down from 60 to 0, at which point it runs the m_bossSpawner.SpawnEnemy () code.
	//After it hits 0, it goes back up to 60.
	public float m_BossSpawnDelay = 60f;
	float m_currentSpawnTimer = 60f;

	public BossSpawner m_bossSpawner;

	void Update () {

		if (m_currentSpawnTimer <= 0) {

			//Thid if statement is here so that 2 bosses cannot be present at the same time.
			if (GameObject.Find ("Boss(Clone)") == null){
			m_bossSpawner.SpawnEnemy ();
			}
			m_currentSpawnTimer = m_BossSpawnDelay;
		}

		if (m_currentSpawnTimer > 0) {
			
			m_currentSpawnTimer -= Time.deltaTime;
		}
	}
}
