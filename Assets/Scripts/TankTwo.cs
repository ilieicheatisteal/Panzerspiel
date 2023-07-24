using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankTwo : MonoBehaviour
{
    int healthTwo = 100;
    public float speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
                  if(Input.GetKey(KeyCode.D))
        {
                transform.Rotate(0, 0, -40 * Time.deltaTime);
        }
            if(Input.GetKey(KeyCode.A))
        {
                transform.Rotate(0, 0, 40 * Time.deltaTime);
        }
            if(Input.GetKey(KeyCode.W))
        {
                transform.Translate(0, speed * Time.deltaTime , 0);
        }
            if(Input.GetKey(KeyCode.S))
        {
                transform.Translate(0, -speed * Time.deltaTime , 0);
        }  
    }

    // Update is called once per frame
    void Update()
    {

    }

        private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Walls") {
            healthTwo -= 30;
        }

            if (healthTwo <= 0)
            {
                Debug.Log("Game Over For Tank 2!");
            }

        }

}
