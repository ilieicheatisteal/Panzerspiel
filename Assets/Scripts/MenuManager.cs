using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
	public GameObject mainMenu;
	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		
	}
	public void play()
	{
		mainMenu.SetActive(false);
		Debug.Log("Play");
	}
	
	public void quit()
	{
		Application.Quit();
		Debug.Log("Quit");
	}
}
