using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Elephant: MonoBehaviour {
	
	public GameObject Dialogue;
	Text DialogueText;
	ParticleSystem dogScent;
	public GameObject jackroom;
	public Text MessageText;
	private bool doorunlocked = false;
	
	void Start()
	{
		DialogueText = Dialogue.GetComponent<Text> ();
		dogScent = gameObject.GetComponentInChildren<ParticleSystem>();
	}
	
	public void objectInteract () 
	{
		jackroom.GetComponent<Animation>().enabled = true;
		if (doorunlocked == false) {
			MessageText.text = "Jack's Bedroom Unlocked.";
			doorunlocked = true;
		}
		DialogueText.text = "Jack: 'It's amazing how just alike Susie and Linda are. I remember when Helen won a toy elephant for Linda at a carnival when she was 10.  Now Suzie loves this thing as much as Linda did. They both carried it everywhere for months after they first saw it.'";
		
		if (dogScent.isPlaying) 
		{
			dogScent.Stop ();
		}
	}
}
