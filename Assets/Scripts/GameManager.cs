using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class GameManager : MonoBehaviour {
	
	private int ObjectLayer;
	private int DoorLayer;
	private bool CastRays = true;	
	public GameObject Dialogue;
	public GameObject Tutorial;
	Text TutorialText;
	Text DialogueText;
	public bool GamePaused;
	public static bool PickedUpObject;
	float startTimer1;
	float startTimer2;
	float delay1 = 15.0f;
	float delay2 = 3.0f;
	public GameObject PauseMenu;
	public AudioClip[] Barking;
	public string ObjectName;
	public string DoorName;
	public GameObject Object;
	public GameObject Door;
	public static bool DogMode;
	public GameObject Sam;
	public GameObject Suzie;
	public CharacterController SamCC;
	public CharacterController SuzieCC;
	public FirstPersonController SamFPC;
	public FirstPersonController SuzieFPC;
	public GameObject SamCam;
	public GameObject SuzieCam;
	public DogFollow SamScript;
	public GirlFollow SuzieScript;
	public Animator SamAnim;
	public Animator SuzieAnim;
	public GameObject SamBody;
	public GameObject SuzieBody;
	public AudioSource SamAudio;
	public AudioSource SuzieAudio;
	public UnityEngine.AI.NavMeshAgent SamNav;
	public UnityEngine.AI.NavMeshAgent SuzieNav;
	public Text MessageText;
	public GameObject Controls;

	void Start () {
		ObjectLayer = LayerMask.NameToLayer("Interactable");
		DoorLayer = LayerMask.NameToLayer ("Door");
		TutorialText = Tutorial.GetComponent<Text> ();
		DialogueText = Dialogue.GetComponent<Text> ();
		GamePaused = (false);
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = (false);
		PauseMenu.SetActive (false);
		PickedUpObject = false;
		DogMode = true;
	}
	
	public void QuitGame()
	{
		Application.Quit();
	}

	void PauseGame ()
	{
		TutorialText.text = "";
		PauseMenu.SetActive (true);
		Time.timeScale = 0;
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = (true);
		MouseLook.XSensitivity = 0;
		MouseLook.YSensitivity = 0;
		GamePaused = (true);
	}

	void ResumeGame()
	{
		PauseMenu.SetActive (false);
		Time.timeScale = 1;
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = (false);
		MouseLook.XSensitivity = 2;
		MouseLook.YSensitivity = 2;
		GamePaused = (false);
	}

	public void Back()
	{
		Controls.SetActive (false);
		PauseGame ();
	}

	public void ViewControls()
	{
		PauseMenu.SetActive (false);
		Controls.SetActive (true);
	}

	void PlayDog() {
		SamCC.enabled = true;
		SuzieCC.enabled = false;
		SamFPC.enabled = true;
		SuzieFPC.enabled = false;
		SamCam.SetActive(true);
		SuzieCam.SetActive(false);
		SamAnim.enabled = false;
		SuzieAnim.enabled = true;
		SamScript.enabled = false;
		SuzieScript.enabled = true;
		SamBody.SetActive(false);
		SuzieBody.SetActive(true);
		SamAudio.enabled = true;
		SuzieAudio.enabled = false;
		SamNav.enabled = false;
		SuzieNav.enabled = true;
		DogMode = true;
	}

	void PlayGirl() {
		SamCC.enabled = false;
		SuzieCC.enabled = true;
		SamFPC.enabled = false;
		SuzieFPC.enabled = true;
		SamCam.SetActive(false);
		SuzieCam.SetActive(true);
		SamAnim.enabled = true;
		SuzieAnim.enabled = false;
		SamScript.enabled = true;
		SuzieScript.enabled = false;
		SamBody.SetActive(true);
		SuzieBody.SetActive(false);
		SamAudio.enabled = false;
		SuzieAudio.enabled = true;
		SamNav.enabled = true;
		SuzieNav.enabled = false;
		DogMode = false;
	}

	void Update() {

		if (Input.GetKeyDown (KeyCode.Tab)) 
		{
			if (DogMode == true) 
			{
				PlayGirl ();
			} 
			else 
			{
				PlayDog();
			}
		}

		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (!GamePaused) {
				PauseGame ();
			} else if (GamePaused) {
				ResumeGame ();
			}
		} 
	
		if (CastRays) {
			Ray ray = Camera.main.ViewportPointToRay (new Vector3 (0.5f, 0.5f, 0f));
			RaycastHit hit;
			if (Input.GetKeyDown (KeyCode.E) && PickedUpObject == true)
			{
				Object.SendMessage ("PutDownObject");
			}
			else if (Physics.Raycast (ray, out hit, 2) && !GamePaused && PickedUpObject == false) {
				if (hit.transform.gameObject.layer == ObjectLayer) {
					ObjectName = hit.collider.gameObject.name;	
					Object = hit.collider.gameObject;
					TutorialText.text = "Press 'E' to interact with \n" + ObjectName;
					
					if (Input.GetKeyDown (KeyCode.E)) {
						int number;
						number = Random.Range (0, Barking.Length);
						if (DogMode == true)
						{
							GetComponent<AudioSource> ().PlayOneShot (Barking [number], 0.3f);
						}
						startTimer1 = Time.time;
						startTimer2 = Time.time;
						Object.SendMessage ("objectInteract");
					}
				} 
				else if (hit.transform.gameObject.layer == DoorLayer && DogMode == false) {
					DoorName = hit.collider.gameObject.name;
					Door = hit.collider.gameObject;
					TutorialText.text = "Press 'E' to open \n" + DoorName;
					if (Input.GetKeyDown (KeyCode.E)) {
						startTimer2 = Time.time;
						Door.SendMessage ("doorInteract");
					}
				} 
				else 
				{
					TutorialText.text = "";
				}
			}
			else 
			{
				TutorialText.text = "";
			}
		}

		if (Time.time > (startTimer1 + delay1)) {
			DialogueText.text = "";
		}

		if (Time.time > (startTimer2 + delay2)) {
			MessageText.text = "";
		}
	}
}