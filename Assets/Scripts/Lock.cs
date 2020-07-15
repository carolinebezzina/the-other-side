using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Lock : MonoBehaviour {
	
	public GameObject[] numbers;
	public Text messages;
	public GameObject lockObject;
	public Animation safeDoor;
	public AudioSource doorCreak;
	public GameObject Tutorial;

	public void changeDown()
	{
		if (numbers [0].activeSelf == true) 
		{
			numbers[0].SetActive(false);
			numbers[9].SetActive(true);
		}
		
		else if (numbers [1].activeSelf == true) 
		{
			numbers[1].SetActive(false);
			numbers[0].SetActive(true);
		}
		
		else if (numbers [2].activeSelf == true) 
		{
			numbers[2].SetActive(false);
			numbers[1].SetActive(true);
		}
		
		else if (numbers [3].activeSelf == true) 
		{
			numbers[3].SetActive(false);
			numbers[2].SetActive(true);
		}
		
		else if (numbers [4].activeSelf == true) 
		{
			numbers[4].SetActive(false);
			numbers[3].SetActive(true);
		}
		
		else if (numbers [5].activeSelf == true) 
		{
			numbers[5].SetActive(false);
			numbers[4].SetActive(true);
		}
		
		else if (numbers [6].activeSelf == true) 
		{
			numbers[6].SetActive(false);
			numbers[5].SetActive(true);
		}
		
		else if (numbers [7].activeSelf == true) 
		{
			numbers[7].SetActive(false);
			numbers[6].SetActive(true);
		}
		
		else if (numbers [8].activeSelf == true) 
		{
			numbers[8].SetActive(false);
			numbers[7].SetActive(true);
		}
		
		else if (numbers [9].activeSelf == true) 
		{
			numbers[9].SetActive(false);
			numbers[8].SetActive(true);
		}
	}

	public void changeUp()
	{
		if (numbers [0].activeSelf == true) 
		{
			numbers[0].SetActive(false);
			numbers[1].SetActive(true);
		}
		
		else if (numbers [1].activeSelf == true) 
		{
			numbers[1].SetActive(false);
			numbers[2].SetActive(true);
		}
		
		else if (numbers [2].activeSelf == true) 
		{
			numbers[2].SetActive(false);
			numbers[3].SetActive(true);
		}
		
		else if (numbers [3].activeSelf == true) 
		{
			numbers[3].SetActive(false);
			numbers[4].SetActive(true);
		}
		
		else if (numbers [4].activeSelf == true) 
		{
			numbers[4].SetActive(false);
			numbers[5].SetActive(true);
		}
		
		else if (numbers [5].activeSelf == true) 
		{
			numbers[5].SetActive(false);
			numbers[6].SetActive(true);
		}
		
		else if (numbers [6].activeSelf == true) 
		{
			numbers[6].SetActive(false);
			numbers[7].SetActive(true);
		}
		
		else if (numbers [7].activeSelf == true) 
		{
			numbers[7].SetActive(false);
			numbers[8].SetActive(true);
		}
		
		else if (numbers [8].activeSelf == true) 
		{
			numbers[8].SetActive(false);
			numbers[9].SetActive(true);
		}
		
		else if (numbers [9].activeSelf == true) 
		{
			numbers[9].SetActive(false);
			numbers[0].SetActive(true);
		}
	}

	public void checkCode()
	{
		if (numbers [0].activeSelf == true && numbers [1].activeSelf == true && numbers [2].activeSelf == true && numbers [3].activeSelf == true) 
		{
			lockObject.SetActive(false);
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = (false);
			Safe.doorLocked = false;
			doorCreak.Play ();
			safeDoor.Play("SafeOpen");
			MouseLook.XSensitivity = 2;
			MouseLook.YSensitivity = 2;
			Tutorial.SetActive(true);
			Safe.doorOpen = true;
		} 
		else 
		{
			messages.text = "Incorrect Code.";
		}
	}

	public void exitLock()
	{
		MouseLook.XSensitivity = 2;
		MouseLook.YSensitivity = 2;
		Tutorial.SetActive(true);
		lockObject.SetActive (false);
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = (false);
	}
}
