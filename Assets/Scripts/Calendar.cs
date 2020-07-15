using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Calendar : MonoBehaviour {
	
	public GameObject Dialogue;
	Text DialogueText;
	ParticleSystem dogScent;
	public GameObject attic;
	public Text MessageText;
	private bool doorunlocked = false;

	void Start()
	{
		DialogueText = Dialogue.GetComponent<Text> ();
		dogScent = gameObject.GetComponentInChildren<ParticleSystem>();
	}
	
	public void objectInteract () 
	{
		attic.GetComponent<Animation>().enabled = true;
		if (doorunlocked == false) {
			MessageText.text = "Attic Unlocked.";
			doorunlocked = true;
		}
		DialogueText.text = "Jack: 'Tomorrow is Helen's birthday. I've been bugging her for weeks to find out what she wants, but keeps telling me 'I just want to spend the day with you.' It's sweet, but I feel like I should do something. Maybe a picnic at the lake. She loves nature...'";
		
		if (dogScent.isPlaying) 
		{
			dogScent.Stop ();
		}
	}
}
