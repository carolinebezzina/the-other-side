using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Book : MonoBehaviour {
	
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
		DialogueText.text = "Suzie: 'Schizophrenia? Why would Grandpa be reading this?'";

		if (dogScent.isPlaying) 
		{
			dogScent.Stop ();
		}
	}
}
