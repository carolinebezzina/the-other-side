using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Flowers : MonoBehaviour {
	
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
		DialogueText.text = "Suzie: 'Roses from the garden. These were Grandma's favourite. Grandpa puts them on the table to remind us of her.'";
		
		if (dogScent.isPlaying) 
		{
			dogScent.Stop ();
		}
	}
}
