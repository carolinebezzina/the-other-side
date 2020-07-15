using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Rings : MonoBehaviour {
	
	public GameObject Dialogue;
	Text DialogueText;
	ParticleSystem dogScent;
	public GameObject nursery;
	public Text MessageText;
	private bool doorunlocked = false;
	
	void Start()
	{
		DialogueText = Dialogue.GetComponent<Text> ();
		dogScent = gameObject.GetComponentInChildren<ParticleSystem>();
	}
	
	public void objectInteract () 
	{
		nursery.GetComponent<Animation>().enabled = true;
		if (doorunlocked == false) {
			MessageText.text = "Nursery Unlocked.";
			doorunlocked = true;
		}
		DialogueText.text = "Jack: 'Married, at the tender age of 19. Helen and I were love at first sight. Was it fate? Destiny? Who knows. I don’t even believe in that stuff. She thinks it was. We started life so young, sometimes I wonder if either of us were even ready. Things were tough back then. I now look back on our younger years and realise just how hard we had worked to get where we are. The things we’d endured, trials, hardships. Life was relentless. But we managed.'";
		
		if (dogScent.isPlaying) 
		{
			dogScent.Stop ();
		}
	}
}
