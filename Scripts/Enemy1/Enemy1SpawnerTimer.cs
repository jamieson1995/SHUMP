using UnityEngine;
using System.Collections;

public class Enemy1SpawnerTimer : MonoBehaviour {

	public float m_Enemy1SpawnDelay = 2f;
	float m_currentSpawnTimer = 0f;

	int m_SpawnerNumber = 0;

	public Enemy1Spawner1 m_enemy1spawner1;
	public Enemy1Spawner2 m_enemy1spawner2;
	public Enemy1Spawner3 m_enemy1spawner3;


	//This function picks a random number between 1 and 3 inclusive.
	void Enemy1SpawnRand(){
		m_SpawnerNumber = Random.Range (1, 4);
	}

	//This function then runs the correct SpawnEnemy function depending upon the outcome the random number.
	void Enemy1Spawner(){
		if (GameObject.Find ("Boss(Clone)") == null){
			if (m_SpawnerNumber == 1) {
				m_enemy1spawner1.SpawnEnemy ();
			}
			if (m_SpawnerNumber == 2) {
				m_enemy1spawner2.SpawnEnemy ();
			}
			if (m_SpawnerNumber == 3) {
				m_enemy1spawner3.SpawnEnemy ();
			}
		}
	}

	void Update(){

		if (m_currentSpawnTimer <= 0) {

			Enemy1SpawnRand();
			Enemy1Spawner();
			m_currentSpawnTimer = m_Enemy1SpawnDelay;
		}

		if (m_currentSpawnTimer > 0) {

			m_currentSpawnTimer -= Time.deltaTime;
		}
	}
	
}