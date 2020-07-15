using UnityEngine;
using System.Collections;

public class Ghost : MonoBehaviour {
	
	public GameObject Jack;
	public static bool endGame = false;

	void Update()
	{
		if (endGame == true) 
		{
			Jack.SetActive(true);
		}
		else if (endGame == false && GameManager.DogMode == false) 
		{
			if (Jack != null && Jack.activeSelf == true)
			{
				Jack.SetActive(false);
			}
		} 
		else if (endGame == false && GameManager.DogMode == true)
		{
			if (Jack != null && Jack.activeSelf == false){
				Jack.SetActive(true);
			}
		}
	}
}