using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonshot : MonoBehaviour
{
    public Transform cannonPoint;
    public GameObject cannonPrefab;

    public float cannonForce = 12f;
    public float firerate;
    private float nextfire;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.B)){
            Cannonshoot();
        }
    }

    void Cannonshoot()
    {
        if(Time.time > nextfire){
            nextfire = Time.time + firerate;
            GameObject cannon = Instantiate(cannonPrefab, cannonPoint.position, cannonPoint.rotation);
            Rigidbody2D rb = cannon.GetComponent<Rigidbody2D>();
            rb.AddForce(cannonPoint.up * cannonForce, ForceMode2D.Impulse); 
        }
    }
}
