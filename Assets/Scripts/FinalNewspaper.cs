using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class FinalNewspaper : MonoBehaviour {
	
	ParticleSystem dogScent;
	public GameObject PickedUpFinalNewspaper;
	public GameObject EndText;
	public GameObject blackScreen;
	public CharacterController Sam;
	public CharacterController Suzie;
	bool animPlay = false;
	public Animation anim;

	void Start()
	{
		dogScent = gameObject.GetComponentInChildren<ParticleSystem> ();
	}

	void Update()
	{
		if (animPlay == true) 
		{
			if (!anim.IsPlaying("BlackFade"))
			{
				Application.LoadLevel("Splash Screen");
			}
		}
	}

	public void objectInteract () 
	{
		GameManager.PickedUpObject = true;
		MouseLook.XSensitivity = 0;
		MouseLook.YSensitivity = 0;
		Time.timeScale = 0;
		PickedUpFinalNewspaper.SetActive (true);
		EndText.SetActive (false);
		
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
		PickedUpFinalNewspaper.SetActive(false);
		GameManager.PickedUpObject = false;
		Sam.enabled = false;
		Suzie.enabled = false;
		blackScreen.SetActive (true);
		animPlay = true;
	}
}
