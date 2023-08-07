using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playertwo : MonoBehaviour
{
	public Sprite destroyedbluetank;
	public AudioSource hitmarker2;
	public AudioSource explosion2;
	float speed = 3.0f;

	void OnCollisionEnter2D(Collision2D collision3)
	{
		if (collision3.gameObject.tag == "bullet")
		{
			hitmarker2.Play();
			scoreone.scoreValue2 -= 2;
		}

		if (collision3.gameObject.tag == "ball")
		{
			explosion2.Play();
			scoreone.scoreValue2 -= 30;
		}
	}
	// Update is called once per frame
	void Update()
	{
		if (scoreone.scoreValue2 <= 0)
		{
			this.gameObject.GetComponent<SpriteRenderer>().sprite = destroyedbluetank;
		}

		if (scoreone.scoreValue2 > 0 && score.scoreValue > 0)
		{

			if (Input.GetKey(KeyCode.UpArrow))
			{
				transform.Translate(0, speed * Time.deltaTime, 0);
			}
			if (Input.GetKey(KeyCode.LeftArrow))
			{
				transform.Rotate(0, 0, 50 * Time.deltaTime);
			}
			if (Input.GetKey(KeyCode.DownArrow))
			{
				transform.Translate(0, -speed * Time.deltaTime, 0);
			}
			if (Input.GetKey(KeyCode.RightArrow))
			{
				transform.Rotate(0, 0, -50 * Time.deltaTime);
			}
		}
	}
}