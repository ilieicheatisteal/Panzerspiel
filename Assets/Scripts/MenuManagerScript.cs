using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagerScript : MonoBehaviour
{
	public void Play()
	{
		SceneManager.LoadScene("SampleScene");
	}

	public void quit()
	{
		SceneManager.LoadScene("Sure");
	}

	public void Options()
	{
		SceneManager.LoadScene("Options");
	}
}

