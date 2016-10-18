using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BombsUI : MonoBehaviour {

	//This script simply displays the correct amount of bombs depending on how many the player has remaining.
	
	[SerializeField]
	Text m_text;
	
	[SerializeField]
	Image m_Bombs1;
	
	[SerializeField]
	Image m_Bombs2;
	
	[SerializeField]
	Image m_Bombs3;
	
	public GameObject m_World;
	
	void Update () {

		if (m_World.GetComponent<Bombs> ().m_Bombs >= 3) {
			m_Bombs3.gameObject.SetActive(true);
			m_Bombs2.gameObject.SetActive(true);
			m_Bombs1.gameObject.SetActive(true);
		}
		if (m_World.GetComponent<Bombs>().m_Bombs == 2){
			m_Bombs3.gameObject.SetActive(false);
			m_Bombs2.gameObject.SetActive(true);
			m_Bombs1.gameObject.SetActive(true);
		}
		
		if (m_World.GetComponent<Bombs>().m_Bombs == 1){
			m_Bombs3.gameObject.SetActive(false);
			m_Bombs2.gameObject.SetActive(false);
			m_Bombs1.gameObject.SetActive(true);
		}
		
		if (m_World.GetComponent<Bombs>().m_Bombs == 0){
			m_Bombs3.gameObject.SetActive(false);
			m_Bombs2.gameObject.SetActive(false);
			m_Bombs1.gameObject.SetActive(false);
		}
	}
}
