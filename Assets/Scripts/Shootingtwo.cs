using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootingtwo : MonoBehaviour
{

    public Transform firePointTwo;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;
    public float firerate1;
    float nextfire1;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.I)){
            Shoot1();
        }
    }

    void Shoot1()
    {
        if(Time.time > nextfire1){
            nextfire1 = Time.time + firerate1;
            GameObject bullet = Instantiate(bulletPrefab, firePointTwo.position, firePointTwo.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePointTwo.up * bulletForce, ForceMode2D.Impulse); 
        }
    }
}
