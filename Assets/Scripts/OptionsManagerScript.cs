using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsManagerScript : MonoBehaviour
{
	public void back()
	{
		SceneManager.LoadScene("MainMenu");
	}
}
