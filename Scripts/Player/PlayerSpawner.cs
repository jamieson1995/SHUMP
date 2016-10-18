using UnityEngine;
using System.Collections;

public class PlayerSpawner : MonoBehaviour {

	//This script is in charge of spawning the player in at the start of the game and when the player
	//loses a life.

    public GameObject m_PlayerPrefab;
    GameObject m_playerInstance;
    float m_respawnTimer;

	float m_InvulnerableTimer = 2f;

	void Start () {
        SpawnPlayer();
	}

	//This function instantiates the player in the correct position and rotation, it also sets the player's
	//layer to 10. The 10th layer is the invulnerablility layer. It needs to be set because when the player respawns
	//after dying, the have 2 seconds of invulnerablility, which is implimentated by changing the player's 
	//current player to 10 on respawn and back to the player layer (8), 2 seconds later. The invulnerability layer
	//can only interact with the powerup layer, allowing enemy ships and bullets to pass through the player with
	//no interaction while the timer is still counting down.
    void SpawnPlayer(){
		m_respawnTimer = 2; //The respawnTimer allows the game to continue for 2 seconds while the player respawns.
		m_playerInstance = (GameObject)Instantiate(m_PlayerPrefab, transform.position, Quaternion.identity);
		m_playerInstance.transform.Rotate(0, 0, 270);
		m_playerInstance.layer = 10;
		m_InvulnerableTimer = 2f;
    }
	
	void Update () {

		m_InvulnerableTimer -= Time.deltaTime;
		if (m_InvulnerableTimer <= 0){
			if (m_playerInstance != null){
				m_playerInstance.layer = 8;
			}
		}
		if (m_playerInstance == null){
			m_respawnTimer -= Time.deltaTime;

			if (m_respawnTimer <= 0){
                SpawnPlayer();
            }
        }
	}
}
