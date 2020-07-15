using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PianoMusic : MonoBehaviour {
	
	public AudioSource[] music;
	public AudioSource piano;

	public void OnTriggerEnter(Collider other)
	{
		if (piano.isPlaying == false)
		{
			music[0].Stop();
			piano.Play();
		}
	}

	public void OnTriggerExit(Collider other)
	{
		if (music [0].isPlaying == false) 
		{
			music [0].Play ();
			piano.Stop ();
		}
	}
}