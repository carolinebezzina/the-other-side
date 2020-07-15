using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DoorsAnimLeft : MonoBehaviour {
	
	private bool doorOpen = false;
	public GameObject pivot;
	private Animation animateDoor;
	private GameObject gameManager;
	private static AudioSource doorCreak;
	public Text MessageText;
	public AudioSource doorLocked;
	
	void Start()
	{
		animateDoor = pivot.GetComponent<Animation>();
		gameManager = GameObject.FindGameObjectWithTag ("GameController");
		doorCreak = gameManager.GetComponent<AudioSource>();
		doorLocked.volume = 0.5f;
	}

	public void doorInteract()
	{
		if (animateDoor.isActiveAndEnabled) {
			if (!animateDoor.isPlaying) {
				if (doorOpen == false) {
					animateDoor.Play ("OpenDoorLeft");
					doorCreak.Play ();
					doorOpen = true;
				} else {
					animateDoor.Play ("CloseDoorLeft");
					doorCreak.Play ();
					doorOpen = false;
				}
			}
		} else {
			MessageText.text = "This door is locked.";	
			doorLocked.Play ();
		}
	}
}
