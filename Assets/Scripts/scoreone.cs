using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreone : MonoBehaviour
{
	public AudioSource death2;
	public bool isDead;

	public GameManagerScript gameManager;

	public static int scoreValue2 = 100;
	Text score2;
	// Start is called before the first frame update
	void Start()
	{
		score2 = GetComponent<Text>();
	}

	// Update is called once per frame
	void Update()
	{
		if (scoreValue2 <= 0 && !isDead)
		{
			death2.Play();
			scoreValue2 = 0;
			isDead = true;
			gameManager.gameOver();
		}
		score2.text = scoreValue2.ToString("0");
	}
}