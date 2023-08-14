using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagerScript : MonoBehaviour
{
	public void Back()
	{
		SceneManager.LoadScene("MainMenu");
	}
	public void Labs()
	{
		SceneManager.LoadScene("SampleScene");
		score.scoreValue = 100;
		scoreone.scoreValue2 = 100;
	}

	public void Cross()
	{
		SceneManager.LoadScene("Cross");
		score.scoreValue = 100;
		scoreone.scoreValue2 = 100;
	}

	public void Freefight()
	{
		SceneManager.LoadScene("NoWalls");
		score.scoreValue = 100;
		scoreone.scoreValue2 = 100;
	}
}
