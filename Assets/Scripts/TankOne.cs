using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankOne : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if(Input.GetKey(KeyCode.LeftArrow))
        {
                transform.Translate(-4 * Time.deltaTime , 0, 0);
        }
            if(Input.GetKey(KeyCode.RightArrow))
        {
                transform.Translate(4 * Time.deltaTime , 0, 0);
        }
            if(Input.GetKey(KeyCode.UpArrow))
        {
                transform.Translate(0, 4 * Time.deltaTime , 0);
        }
            if(Input.GetKey(KeyCode.DownArrow))
        {
                transform.Translate(0, -4 * Time.deltaTime , 0);
        }
    }
}
