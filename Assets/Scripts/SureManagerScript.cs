using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SureManagerScript : MonoBehaviour
{
	public void yes()
	{
		Application.Quit();
		Debug.Log("Quit");
	}

	public void no()
	{
		SceneManager.LoadScene("MainMenu");
	}
}