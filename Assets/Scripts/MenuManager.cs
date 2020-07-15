using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour {

	public GameObject MainMenu;
	public GameObject SplashScreen;
	public GameObject IntroText;
	public GameObject Dog;
	private bool splash = true;
	
	public void LoadGame() 
	{
		splash = false;
		MainMenu.SetActive (false);
		Dog.SetActive (false);
		IntroText.SetActive (true);
	}

	public void QuitGame()
	{
		Application.Quit();
	}

	void Update()
	{
		if (splash == true && Input.GetKeyDown(KeyCode.Space))
		{
			SplashScreen.SetActive(false);
			MainMenu.SetActive(true);
		}
		if (splash == false && Input.GetKeyDown(KeyCode.Space))
		{
			Application.LoadLevel ("Game Scene");
		}
	}
}