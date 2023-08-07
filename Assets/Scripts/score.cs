using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
	public AudioSource death1;
	public bool isDead;

	public GameManagerScript gameManager;

	public static int scoreValue = 100;
	Text score1;

	// Start is called before the first frame update
	void Start()
	{
		score1 = GetComponent<Text>();
	}

	// Update is called once per frame
	void Update()
	{
		if (scoreValue <= 0 && !isDead)
		{
			death1.Play();
			scoreValue = 0;
			isDead = true;
			gameManager.gameOver();
		}
		score1.text = scoreValue.ToString("0");
	}
}