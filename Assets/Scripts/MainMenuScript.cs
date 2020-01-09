using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
	public void PlayGame()
	{
		SceneManager.LoadScene("MainGameplay");
	}
	
	public void Quit()
	{
		Debug.Log("Quit");
		Application.Quit();
	}
}
