using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Mirror : MonoBehaviour {
	
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
		DialogueText.text = "Jack: 'I close my eyes. I see her face. I look in the mirror I see her reflection standing over me. I can't sleep. I can't eat. I sit in this attic day in and day out. Writing. I hear her whispers in my ear as I sit quietly... alone. This can't go on.'";
		
		if (dogScent.isPlaying) 
		{
			dogScent.Stop ();
		}
	}
}
