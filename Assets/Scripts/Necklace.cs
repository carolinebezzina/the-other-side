using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Necklace : MonoBehaviour {
	
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
		DialogueText.text = "Jack: 'After Helen died I passed on her most precious jewelry to Linda at her request. Linda was surprised when I presented them to her. She had always loved the necklace the most. Said it suited Helen. She wears it most days. She looks just like her mother...'";
		
		if (dogScent.isPlaying) 
		{
			dogScent.Stop ();
		}
	}
}
