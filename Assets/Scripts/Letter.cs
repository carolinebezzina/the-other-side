using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Letter : MonoBehaviour {
	
	ParticleSystem dogScent;
	public GameObject PickedUpLetter;
	
	void Start()
	{
		dogScent = gameObject.GetComponentInChildren<ParticleSystem> ();
	}
	
	public void objectInteract () 
	{
		GameManager.PickedUpObject = true;
		MouseLook.XSensitivity = 0;
		MouseLook.YSensitivity = 0;
		Time.timeScale = 0;
		PickedUpLetter.SetActive (true);
		
		if (dogScent.isPlaying) 
		{
			dogScent.Stop ();
		}
	}

	public void PutDownObject()
	{
		Time.timeScale = 1;
		MouseLook.XSensitivity = 2;
		MouseLook.YSensitivity = 2;
		PickedUpLetter.SetActive (false);
		GameManager.PickedUpObject = false;
	}
}
