using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagerScript : MonoBehaviour
{
	public void Play()
	{
		SceneManager.LoadScene("SampleScene");
		score.scoreValue = 100;
		scoreone.scoreValue2 = 100;
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

