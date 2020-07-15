using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RockingChair : MonoBehaviour {
	
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
		DialogueText.text = "Suzie: 'What's going on with Grandpa's chair? Why is it rocking like that? Strange...'";

		if (dogScent.isPlaying) 
		{
			dogScent.Stop ();
		}
	}
}
