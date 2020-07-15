using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Backpack : MonoBehaviour {
	
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
		DialogueText.text = "Jack: 'Today is Suzie's first day at school. I was so proud of her. Most kids would have been terrified but she was brave, and excited. She couldn't go fast enough. She had her mother's inquisitive nature. Seems like just yesterday Linda was at school. How time flies...'";
		
		if (dogScent.isPlaying) 
		{
			dogScent.Stop ();
		}
	}
}
