using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class FinalClue : MonoBehaviour {

	public GameObject confirmation;
	public GameObject Tutorial;
	public Text DialogueText;
	public Text MessagesText;
	public GameObject Colliders;
	public GameObject House;
	public GameObject EndText;
	public GameObject FinalNewspaper;
	public Material skybox3;
	public Skybox skybox1;
	public Skybox skybox2;

	public void objectInteract () 
	{
		Tutorial.SetActive (false);
		DialogueText.text = "";
		MessagesText.text = "";
		Time.timeScale = 0;
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = (true);
		MouseLook.XSensitivity = 0;
		MouseLook.YSensitivity = 0;
		confirmation.SetActive (true);
	}

	public void keepLooking()
	{
		Tutorial.SetActive (true);
		Time.timeScale = 1;
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = (false);
		MouseLook.XSensitivity = 2;
		MouseLook.YSensitivity = 2;
		confirmation.SetActive (false);
	}

	public void readPages()
	{
		Time.timeScale = 1;
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = (false);
		MouseLook.XSensitivity = 2;
		MouseLook.YSensitivity = 2;
		confirmation.SetActive (false);
		Tutorial.SetActive (true);
		Colliders.SetActive (true);
		skybox1.material = skybox3;
		skybox2.material = skybox3;
		House.SetActive (false);
		FinalNewspaper.SetActive (true);
		Ghost.endGame = true;
		EndText.SetActive (true);
	}
}
