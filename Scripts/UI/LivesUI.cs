using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LivesUI : MonoBehaviour {

	//This script displays the correct lives depending upon the amount of lives the player has left.

	[SerializeField]
	Text m_text;

	[SerializeField]
	Image m_Lives1;

	[SerializeField]
	Image m_Lives2;

	[SerializeField]
	Image m_Lives3;

	public GameObject m_World;

	void Update () {

		if (m_World.GetComponent<Lives>().m_Lives >= 3){
			m_Lives3.gameObject.SetActive(true);
			m_Lives2.gameObject.SetActive(true);
			m_Lives1.gameObject.SetActive(true);
		}
		if (m_World.GetComponent<Lives>().m_Lives == 2){
			m_Lives3.gameObject.SetActive(false);
			m_Lives2.gameObject.SetActive(true);
			m_Lives1.gameObject.SetActive(true);
		}

		if (m_World.GetComponent<Lives>().m_Lives == 1){
			m_Lives3.gameObject.SetActive(false);
			m_Lives2.gameObject.SetActive(false);
			m_Lives1.gameObject.SetActive(true);		}

		if (m_World.GetComponent<Lives>().m_Lives == 0){
			m_Lives3.gameObject.SetActive(false);
			m_Lives2.gameObject.SetActive(false);
			m_Lives1.gameObject.SetActive(false);		
		}
	}
}
