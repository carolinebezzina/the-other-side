using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Song : MonoBehaviour {
	
	public GameObject Dialogue;
	Text DialogueText;
	ParticleSystem dogScent;
	
	void Start()
	{
		DialogueText = Dialogue.GetComponent<Text> ();
		dogScent = gameObject.GetComponentInChildren<ParticleSystem>();
	}
	
	public void objectInteract () 
	{
		DialogueText.text = "Jack: 'I dusted off the old piano today. I wrote her a song. It was played on our wedding day. I play it over and over. I see her dancing in my head. How I wish I could dance with her just one more time...'";
		
		if (dogScent.isPlaying) 
		{
			dogScent.Stop ();
		}
	}
}
