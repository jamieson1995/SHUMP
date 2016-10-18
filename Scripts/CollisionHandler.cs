using UnityEngine;
using System.Collections;

public class CollisionHandler : MonoBehaviour {

	//This is the most complex script I have implementated. It handles all collisions and
	//runs certain code based upon what the current gameObject is or what the gameObject was that
	//collided with this one.

	public int m_MaxHealth = 1;
	int m_CurrentHealth = 1;

	GameObject m_World;
	public GameObject m_MobileScore100Prefab;
	GameObject m_MobileScore100;
	public GameObject m_MobileScore200Prefab;
	GameObject m_MobileScore200;

	GameObject m_boss;

	AudioSource[] m_Sounds;
	AudioSource m_Explosion1;
	AudioSource m_Explosion2;
	AudioSource m_BossDestroyed;
	AudioSource m_PowerUp;

	Vector3 m_pos;

	int m_Multiplier;
	
	void Start() {
		m_World = GameObject.Find ("World");
		m_Sounds = m_World.GetComponents<AudioSource> ();
		m_Explosion1 = m_Sounds [0]; 
		m_Explosion2 = m_Sounds [1];
		m_BossDestroyed = m_Sounds [2];
		m_PowerUp = m_Sounds [3];
		m_CurrentHealth = m_MaxHealth;
	}

	//This runs when 2 gameObjects with colliders, collide.
	void OnTriggerEnter2D(Collider2D Object){

		//This if statment is needed so that the player does not take damage from picking up Powerups.
		if (Object.tag != "PowerUp") {
			m_CurrentHealth--;
		}
	}

	void Update () {

		m_boss = GameObject.Find ("Boss(Clone)");;

		if (m_CurrentHealth <= 0) {
			Death();
		}
		m_Multiplier = m_World.GetComponent<MultiplierTimer>().MultiplierValue;
	}

	//This function runs whenever a gameObject's health drops below 1.
	void Death(){
		//This runs if the gameObject is the player.
		if (gameObject.name == "Player(Clone)") {
			m_World.GetComponent<Lives>().PlayerHit();
			m_World.GetComponent<MultiplierTimer>().MultiplierValue = 1;
			m_World.GetComponent<MultiplierTimer>().M_CurrentMultiplierTimer = 30f;
			m_Explosion2.Play();	
		}

		//This runs if the gameObject is enemy1.
		if (gameObject.name == "Enemy1(Clone)") {
		
			m_World.GetComponent<Score>().ScoreAddition(100*m_Multiplier);
				m_Explosion1.Play();
		}

		//This runs if the gameObject is enemy2.
		if (gameObject.name == "Enemy2(Clone)") {

			m_World.GetComponent<Score>().ScoreAddition(200*m_Multiplier);
			m_Explosion1.Play();
		}

		//This runs if the gameObject is a PlayerShip powerup.
		if (gameObject.name == "PlayerShipPowerUp(Clone)") {
			m_World.GetComponent<Lives>().m_Lives = 3;
			m_PowerUp.Play();
		}

		//This runs if the gameObject is a Bomb powerup.
		if (gameObject.name == "BombPowerUp(Clone)") {
			m_World.GetComponent<Bombs>().m_Bombs = 3;
			m_PowerUp.Play();
		}

		//This runs if the gameObject is the Weak_Point.
		//Notice how there is no option for if the boss takes damage, this is
		//because he cannot take damage, all the collisions are handled by the
		//Weak_Point gameObject, this is because this is what causes the boss to
		//take damage, because if this, when the Weak_Point's health becomes 0, it
		//destroys the boss gameObject as well as itself.

		if (gameObject.name == "Weak_Point(Clone)") {
			m_World.GetComponent<Score>().ScoreAddition(1000*m_Multiplier);
			m_BossDestroyed.Play ();
			Destroy (m_boss);
			Destroy (gameObject);
		} else {
			Destroy (gameObject);
		}
	}
}
