using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Medication : MonoBehaviour {
	
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
		DialogueText.text = "Suzie: 'Grandpa's taking medication? Wait... if this is here, that means he didn't take it with him on his hunting trip! That can't be good...'";
		
		if (dogScent.isPlaying) 
		{
			dogScent.Stop ();
		}
	}
}
