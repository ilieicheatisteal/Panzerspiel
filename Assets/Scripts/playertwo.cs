using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playertwo : MonoBehaviour
{
	public AudioSource hitmarker2;
	public AudioSource explosion2;
	float speed = 3.0f;
	// Start is called before the first frame update
	void Start()
	{
	}

	void OnCollisionEnter2D(Collision2D collision3){
		if(collision3.gameObject.tag == "bullet") {
			hitmarker2.Play();
		}

		if(collision3.gameObject.tag == "ball") {
			explosion2.Play();
		}
	}
   // Update is called once per frame
	void Update()
	{
		if(Input.GetKey(KeyCode.UpArrow)){
			transform.Translate(0, speed * Time.deltaTime, 0);
		}
			if(Input.GetKey(KeyCode.LeftArrow)){
			transform.Rotate(0, 0, 50 * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.DownArrow)){
			transform.Translate(0, -speed * Time.deltaTime, 0);
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			transform.Rotate(0, 0, -50 * Time.deltaTime);
		}
	}
}