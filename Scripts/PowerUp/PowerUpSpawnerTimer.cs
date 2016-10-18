using UnityEngine;
using System.Collections;

public class PowerUpSpawnerTimer : MonoBehaviour {

	public float m_PowerupSpawnDelay = 25f;
	float m_currentSpawnTimer = 25f;

	int m_SpawnerNumber = 0;
	int m_TypeNumber = 0;

	public PowerUpSpawner1 m_PowerUpspawner1;
	public PowerUpSpawner2 m_PowerUpspawner2;


	//These 2 functions picks a 1 or a 2 at random.
	void PowerUpSpawnRand(){
		m_SpawnerNumber = Random.Range (1, 3);
	}

	void PowerUpTypeRand(){
		m_TypeNumber = Random.Range (1, 3);
	}

	//This function spawns the correct powerup at the correct spawner depending upon the above random numbers.
	void PowerUpSpawner(){
		if (GameObject.Find ("Boss(Clone)") == null){
			if (m_TypeNumber == 1){
				if (m_SpawnerNumber == 1) {
					m_PowerUpspawner1.SpawnPowerUp1 ();
				}
				if (m_SpawnerNumber == 2) {
					m_PowerUpspawner2.SpawnPowerUp1 ();
				}
			}
			if (m_TypeNumber == 2){
				if (m_SpawnerNumber == 1) {
					m_PowerUpspawner1.SpawnPowerUp2 ();
				}
				if (m_SpawnerNumber == 2) {
					m_PowerUpspawner2.SpawnPowerUp2 ();
				}
			}

		}
	}

	void Update(){
		
		if (m_currentSpawnTimer <= 0) {
			
			PowerUpSpawnRand();
			PowerUpTypeRand();
			PowerUpSpawner();
			m_currentSpawnTimer = m_PowerupSpawnDelay 	;
		}
		
		if (m_currentSpawnTimer > 0) {
			
			m_currentSpawnTimer -= Time.deltaTime;
		}
	}
}
