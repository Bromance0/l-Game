using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    float cdTimer = 0;
    public float shootDelay = 0.2f;

    public GameObject bulletPrefab;
   
    void Update()
    {

        cdTimer -= Time.deltaTime;

        if (Input.GetButton("Fire1") && cdTimer <= 0)
        {
            Debug.Log("Hit!");

            cdTimer = shootDelay;

            Vector3 gunpos = transform.rotation * new Vector3(0, 0.5f, 0);

            Instantiate(bulletPrefab, transform.position + gunpos, transform.rotation);


        }
    }
}
