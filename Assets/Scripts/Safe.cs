using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Safe : MonoBehaviour {

	
	public GameObject Dialogue;
	Text DialogueText;
	public GameObject Tutorial;
	public ParticleSystem dogScent;
	public GameObject unlock;
	public static bool doorLocked = true;
	public Animation safeDoor;
	public static bool doorOpen = true;
	public AudioSource doorCreak;

	void Start()
	{
		DialogueText = Dialogue.GetComponent<Text> ();
	}

	public void objectInteract () 
	{
		if (doorLocked == true) {
			unlock.SetActive (true);
			DialogueText.text = "";
			Tutorial.SetActive (false);
			MouseLook.XSensitivity = 0;
			MouseLook.YSensitivity = 0;
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = (true);

			if (dogScent.isPlaying) {
				dogScent.Stop ();
			}
		} else if (doorLocked == false && doorOpen == true) {
			safeDoor.Play ("SafeClose");
			doorOpen = false;
			doorCreak.Play ();
		} else if (doorLocked == false && doorOpen == false) {
			safeDoor.Play ("SafeOpen");
			doorOpen = true;
			doorCreak.Play ();
		}
	}
}
