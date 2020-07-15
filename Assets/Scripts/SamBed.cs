using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SamBed : MonoBehaviour {
	
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
		DialogueText.text = "Suzie: 'I remember when Grandpa brought you home that night he found you, Sam. You were so tiny! You were shivering because you were wet from the rain, so we put you next to the fireplace and Grandpa sat in his chair watching you all night. You sat there every night since.'";

		if (dogScent.isPlaying) 
		{
			dogScent.Stop ();
		}
	}
}
