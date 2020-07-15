using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Obituary : MonoBehaviour {
	
	ParticleSystem dogScent;
	public GameObject PickedUpObituary;
	
	void Start()
	{
		dogScent = gameObject.GetComponentInChildren<ParticleSystem> ();
	}
	
	public void objectInteract () 
	{
		GameManager.PickedUpObject = true;
		Time.timeScale = 0;
		MouseLook.XSensitivity = 0;
		MouseLook.YSensitivity = 0;
		PickedUpObituary.SetActive (true);
		
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
		PickedUpObituary.SetActive(false);
		GameManager.PickedUpObject = false;
	}
}
