using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Journal : MonoBehaviour {
	
	public GameObject Dialogue;
	Text DialogueText;
	ParticleSystem dogScent;
	public GameObject jameslindaroom1;
	public GameObject jameslindaroom2;
	public Text MessageText;
	private bool doorunlocked = false;
	
	void Start()
	{
		DialogueText = Dialogue.GetComponent<Text> ();
		dogScent = gameObject.GetComponentInChildren<ParticleSystem>();
	}
	
	public void objectInteract () 
	{
		jameslindaroom1.GetComponent<Animation>().enabled = true;
		jameslindaroom2.GetComponent<Animation>().enabled = true;
		if (doorunlocked == false) {
			MessageText.text = "James and Linda's Bedroom Unlocked.";
			doorunlocked = true;
		}
		DialogueText.text = "Jack: 'The most peculiar thing happened today. I found an old journal written by my father, detailing the highlights of his life. After reading it, I felt inspired. My experiences with my father were always good, and to read his version of our life together when he was alive was an amazing feeling. A feeling I would love to one day share with my children. So today I start a journal of my own. I will detail the important events in my life and one day share them with my children, and their children.' \n \n Suzie: 'Look Sam, some of the pages are torn out!'";
		
		if (dogScent.isPlaying) 
		{
			dogScent.Stop ();
		}
	}
}
