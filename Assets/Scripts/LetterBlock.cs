using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LetterBlock : MonoBehaviour {
	
	public GameObject Dialogue;
	Text DialogueText;
	ParticleSystem dogScent;
	public GameObject bathroom;
	public Text MessageText;
	private bool doorunlocked = false;
	
	void Start()
	{
		DialogueText = Dialogue.GetComponent<Text> ();
		dogScent = gameObject.GetComponentInChildren<ParticleSystem>();
	}
	
	public void objectInteract () 
	{
		bathroom.GetComponent<Animation>().enabled = true;
		if (doorunlocked == false) {
			MessageText.text = "Bathroom Unlocked.";
			doorunlocked = true;
		}
		DialogueText.text = "Jack: 'We started planning a family today. A few months before Helens 22nd birthday. She has always wanted kids. The thought scares me, but excites me. She hopes to have a son and a daughter. She’s started trying on names, especially girls names. She seems to have a liking for a name starting with L.'";
		
		if (dogScent.isPlaying) 
		{
			dogScent.Stop ();
		}
	}
}
