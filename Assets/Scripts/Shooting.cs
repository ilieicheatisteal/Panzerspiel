using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

	public Transform firePoint;
	public GameObject bulletPrefab;
	public AudioSource gunfire;

	public float bulletForce = 10f;
	public float firerate;
	float nextfire;
	// Update is called once per frame
	void Update()
	{
		if (score.scoreValue > 0 && scoreone.scoreValue2 > 0)
		{
			if (Input.GetKey(KeyCode.V))
			{
				Shoot();
			}
		}
	}

	void Shoot()
	{
		if (Time.time > nextfire)
		{
			nextfire = Time.time + firerate;
			GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
			Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
			rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
		}
	}
}