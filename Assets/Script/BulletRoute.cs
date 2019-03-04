using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletRoute : MonoBehaviour
{
    public float maxSpeed = 5f;


    void Update()
    {
        Vector3 position = transform.position;

        Vector3 acce = new Vector3(0, maxSpeed * Time.deltaTime, 0);

        position += transform.rotation * acce;

        transform.position = position;
    }
}
