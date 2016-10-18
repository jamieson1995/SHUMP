using UnityEngine;
using System.Collections;

public class Bombs : MonoBehaviour {

	public int m_Bombs = 3;

	//This is run when the player uses a bomb.

	public void Bomb(){
		m_Bombs = m_Bombs - 1;
	}
}
