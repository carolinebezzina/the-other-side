using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CrumpledPaper : MonoBehaviour {
	
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
		DialogueText.text = "Jack: 'Helen... Helen.... Helen.... I write her name over and over. But it doesn't bring her back to me. It brings me no comfort. Only pain. Why have you gone? I should be with you! We were meant to be together for a full lifetime. I know one day I'll see you again. But it's not soon enough...'";
		
		if (dogScent.isPlaying) 
		{
			dogScent.Stop ();
		}
	}
}
