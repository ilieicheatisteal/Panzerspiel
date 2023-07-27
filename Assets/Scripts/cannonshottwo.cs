using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonshottwo : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform cannonPointTwo;
    public GameObject cannonPrefab;

    public float cannonForce = 12f;
    public float firerate;
    float nextfire;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.O)){
            Cannonshoottwo();
        }
    }

    void Cannonshoottwo()
    {
        if(Time.time > nextfire){
            nextfire = Time.time + firerate;
             GameObject cannon = Instantiate(cannonPrefab, cannonPointTwo.position, cannonPointTwo.rotation);
            Rigidbody2D rb = cannon.GetComponent<Rigidbody2D>();
            rb.AddForce(cannonPointTwo.up * cannonForce, ForceMode2D.Impulse); 
        }
    }
}
