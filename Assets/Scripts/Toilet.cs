using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Toilet : MonoBehaviour {
	
	public GameObject Dialogue;
	Text DialogueText;
	ParticleSystem dogScent;
	public GameObject suzieroom;
	public Text MessageText;
	private bool doorunlocked = false;

	void Start()
	{
		DialogueText = Dialogue.GetComponent<Text> ();
		dogScent = gameObject.GetComponentInChildren<ParticleSystem>();
	}
	
	public void objectInteract () 
	{
		suzieroom.GetComponent<Animation>().enabled = true;
		if (doorunlocked == false) {
			MessageText.text = "Suzie's Bedroom Unlocked.";
			doorunlocked = true;
		}
		DialogueText.text = "Jack: 'Helen woke early as usual today. She spent the first 20 minutes of the morning in the bathroom, sick. A chill hit me. Was she feeling sick because of morning sickness? She came from the bathroom to find me smiling. She gave me a look as if to say “Why does this make you happy?” Until I told her what it could mean. She forced a smile. I could tell she didn’t feel good, so I sat her down and made her some breakfast and tea.'";
		
		if (dogScent.isPlaying) 
		{
			dogScent.Stop ();
		}
	}
}
