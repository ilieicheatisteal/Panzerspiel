using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerone : MonoBehaviour
{
	public int maxHealth = 100;
	public int currentHealth;
	public healthbar healthbar;
	public AudioSource hitmarker;
	public AudioSource explosion;
	float speed = 3.0f;
	// Start is called before the first frame update
	void Start()
	{
		currentHealth = maxHealth;
		healthbar.SetMaxHealth(maxHealth);
	}

	void OnCollisionEnter2D(Collision2D collision2){
		if(collision2.gameObject.tag == "bullet") {
			hitmarker.Play();
		}

		if(collision2.gameObject.tag == "ball") {
			explosion.Play();
		}
	}
	// Update is called once per frame
	void Update()
	{
		if(Input.GetKey(KeyCode.W)){
			transform.Translate(0, speed * Time.deltaTime, 0);
		}
			if(Input.GetKey(KeyCode.A)){
			transform.Rotate(0, 0, 50 * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.S)){
			transform.Translate(0, -speed * Time.deltaTime, 0);
		}
		if(Input.GetKey(KeyCode.D)){
			transform.Rotate(0, 0, -50 * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.Space)){
			TakeDamage(20);
		}
	}
	
	void TakeDamage(int damage)
	{
		currentHealth -= damage;
		
		healthbar.SetHealth(currentHealth);
	}
}
