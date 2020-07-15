using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Clothes : MonoBehaviour {
	
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
		DialogueText.text = "Suzie: 'This is what Grandpa was wearing on his hunting trip. Look Sam, there's crumpled up paper in his pocket and all over the floor!'";
		
		if (dogScent.isPlaying) 
		{
			dogScent.Stop ();
		}
	}
}
