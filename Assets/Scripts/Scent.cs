using UnityEngine;
using System.Collections;

public class Scent : MonoBehaviour {

	ParticleSystem dogScent;
	public GameObject Jack;

	void Start()
	{
		dogScent = gameObject.GetComponentInChildren<ParticleSystem> ();
		dogScent.enableEmission = false;
	}

	public void OnTriggerEnter(Collider other)
	{
		Destroy(Jack);
		if (dogScent.enableEmission == false && GameManager.DogMode == true) 
		{
			dogScent.enableEmission = true;
		}
	}

	public void OnTriggerExit(Collider other)
	{
		if (dogScent.enableEmission == true && GameManager.DogMode == true) 
		{
			dogScent.enableEmission = false;
		}
	}	

	void Update()
	{
		if (GameManager.DogMode == false) {
			dogScent.enableEmission = false;
		}
	}
}
