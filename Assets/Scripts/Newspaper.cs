using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Newspaper : MonoBehaviour {

	ParticleSystem dogScent;
	public GameObject PickedUpNewspaper;
	public GameObject study;
	public Text MessageText;
	private bool doorunlocked = false;

	void Start()
	{
		dogScent = gameObject.GetComponentInChildren<ParticleSystem> ();
	}
	
	public void objectInteract () 
	{
		study.GetComponent<Animation>().enabled = true;
		GameManager.PickedUpObject = true;
		MouseLook.XSensitivity = 0;
		MouseLook.YSensitivity = 0;
		Time.timeScale = 0;
		PickedUpNewspaper.SetActive (true);

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
			PickedUpNewspaper.SetActive(false);
			GameManager.PickedUpObject = false;
		if (doorunlocked == false) {
			MessageText.text = "Study Unlocked.";
			doorunlocked = true;
		}
	}
}
