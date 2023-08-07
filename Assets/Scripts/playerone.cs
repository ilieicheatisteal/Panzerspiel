using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerone : MonoBehaviour
{
	public bool canMove;
	public Sprite destroyedgreentank;
	public AudioSource hitmarker;
	public AudioSource explosion;
	public AudioSource lose;
	float speed = 3.0f;
	// Start is called before the first frame update
	void Start()
	{

	}

	void OnCollisionEnter2D(Collision2D collision2)
	{
		if (collision2.gameObject.tag == "bullet")
		{
			hitmarker.Play();
			score.scoreValue -= 2;
		}


		if (collision2.gameObject.tag == "ball")
		{
			explosion.Play();
			score.scoreValue -= 30;
		}
	}
	// Update is called once per frame
	void Update()
	{

		if (score.scoreValue <= 0)
		{
			this.gameObject.GetComponent<SpriteRenderer>().sprite = destroyedgreentank;
		}
		if (score.scoreValue > 0 && scoreone.scoreValue2 > 0)
		{

			if (Input.GetKey(KeyCode.W))
			{
				transform.Translate(0, speed * Time.deltaTime, 0);
			}
			if (Input.GetKey(KeyCode.A))
			{
				transform.Rotate(0, 0, 50 * Time.deltaTime);
			}
			if (Input.GetKey(KeyCode.S))
			{
				transform.Translate(0, -speed * Time.deltaTime, 0);
			}
			if (Input.GetKey(KeyCode.D))
			{
				transform.Rotate(0, 0, -50 * Time.deltaTime);
			}
		}
	}
}
