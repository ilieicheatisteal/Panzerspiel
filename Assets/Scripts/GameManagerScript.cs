using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManagerScript : MonoBehaviour
{
	public GameObject gameOverUI;

	public void gameOver()
	{
		gameOverUI.SetActive(true);
	}

	public void restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		gameOverUI.SetActive(false);
		score.scoreValue = 100;
		scoreone.scoreValue2 = 100;
	}

	public void MainMenu()
	{
		SceneManager.LoadScene("MainMenu");
	}
}
