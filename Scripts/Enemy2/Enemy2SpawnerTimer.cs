using UnityEngine;
using System.Collections;

public class Enemy2SpawnerTimer : MonoBehaviour {

	//This is a simply script which counts down from 15 to 0, at which point it will call the m_enemy2spawner1.SpawnEnemy()
	//function which will instantiate a single Enemy2 at each spawner position. So 4 will spawn at once.

	public float m_Enemy2SpawnDelay = 15f;
	float m_currentSpawnTimer = 15f;

	public Enemy2Spawner m_enemy2spawner1;
	public Enemy2Spawner m_enemy2spawner2;
	public Enemy2Spawner m_enemy2spawner3;
	public Enemy2Spawner m_enemy2spawner4;
		
	void Update(){
		
		if (m_currentSpawnTimer <= 0) {
			if (GameObject.Find ("Boss(Clone)") == null){
				m_enemy2spawner1.SpawnEnemy();
				m_enemy2spawner2.SpawnEnemy();
				m_enemy2spawner3.SpawnEnemy();
				m_enemy2spawner4.SpawnEnemy();
			}
			m_currentSpawnTimer = m_Enemy2SpawnDelay;
		}
				
		if (m_currentSpawnTimer > 0) {
			
			m_currentSpawnTimer -= Time.deltaTime;
		}
	}
	
}