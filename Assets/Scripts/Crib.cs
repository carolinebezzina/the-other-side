using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Crib : MonoBehaviour {
	
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
		DialogueText.text = "Jack: 'It’s been a while since I even thought about writing in this thing. Life has been busy and I almost forgot I even had it lying around. Helen is now 4 months along in the pregnancy. The morning sickness still plagues her, but when she is well, she is glowing. She has never been more beautiful. We started preparing the baby’s room. We haven’t decided if we want to know the sex of the baby yet. But perhaps soon.'";
		
		if (dogScent.isPlaying) 
		{
			dogScent.Stop ();
		}
	}
}
