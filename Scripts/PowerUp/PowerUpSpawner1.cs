using UnityEngine;
using System.Collections;

public class PowerUpSpawner1 : MonoBehaviour {

	//This script is in charge of instantiating either the m_PowerUp1PreFab or the m_PowerUp2PreFab.

	public GameObject m_PowerUp1PreFab;
	public GameObject m_PowerUp2PreFab;

	public void SpawnPowerUp1()
	{
		Instantiate(m_PowerUp1PreFab, transform.position, Quaternion.identity);
	}

	public void SpawnPowerUp2()
	{
		Instantiate(m_PowerUp2PreFab, transform.position, Quaternion.identity);
	}
}
