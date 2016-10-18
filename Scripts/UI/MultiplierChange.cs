using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class MultiplierChange : MonoBehaviour {

	//This script changes the text for the multiplier so the player can see what multiplier they are on.

	[SerializeField]
	Text m_text;

	int m_Multiplier;

	public GameObject m_World;
	
	void Update () {
			m_Multiplier = m_World.GetComponent<MultiplierTimer>().MultiplierValue;
			m_text.text = "X" + m_Multiplier;
	}
}
