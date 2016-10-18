using UnityEngine;
using System.Collections;

public class Bomb_Control : MonoBehaviour {

	GameObject[] m_Enemies;

	AudioSource[] m_Sounds;
	AudioSource	m_Bomb;

	Touch m_Touch;

	//This converts the world center to the correct screen center so that the center of the screen can be 
	//used as a reference.
	Vector3 m_CameraCenter = Camera.main.WorldToScreenPoint (new Vector3 (0.5f, 0.5f, 0f));
	
	void Start(){
		m_Sounds = GetComponents<AudioSource> ();
		m_Bomb = m_Sounds [4];
	}

	void Update () {
			m_Touch = Input.GetTouch (1);

		//The TouchPhase.Began means the the player cannot hold down thier finger to set off 
		//more than one bomb, this is a good thing for them as the bombs were being used unintentionally.
		if (Input.GetTouch(1).phase == TouchPhase.Began){

			//This if statement means the code will only run if the player touches the right side of the screen.
			if (m_Touch.position.x >= m_CameraCenter.x) {

				//This is statement means that the code will only run if the player has 1 or more bombs remaining.
				if (gameObject.GetComponent<Bombs> ().m_Bombs > 0){
					gameObject.GetComponent<Bombs> ().Bomb ();
					m_Bomb.Play ();	

					//This will find all gameObjects with the Enemy tag and destroy them.
					m_Enemies = GameObject.FindGameObjectsWithTag("Enemy");
					foreach( GameObject m_Enemy in m_Enemies){
						Destroy(m_Enemy);
					}
				}
		}

		}
	}

}
