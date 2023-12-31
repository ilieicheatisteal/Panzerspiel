using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    public GameObject hitEffect;
    public AudioSource explosion;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "tank")
        {
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 1.0f);
            Destroy(effect, 0.1f);
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Walls")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "ball")
        {
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 1.0f);
            Destroy(gameObject);
            explosion.Play();
        }
    }
}