using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Doors : MonoBehaviour {
	
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
		DialogueText.text = "Suzie: 'Mum has spent alot of time outside crying since Grandpa died and Dad went to jail. We shouldn't disturb her.'";
		if (dogScent.isPlaying) 
		{
			dogScent.Stop ();
		}
	}
}
