using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgainstPlayer : MonoBehaviour
{

    Transform player;

    public float rotationSpeed = 90f;

    void Update()
    {
        if (player == null)
        {
            GameObject go = GameObject.Find("spaceship 1");

            if (go != null)
            {
                player = go.transform;
            }
        }

        if (player == null)
        {
            return;
        }

        Vector3 direction = player.position - transform.position;
        direction.Normalize();

        float Z = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;

        Quaternion roationEnemy = Quaternion.Euler(0,0,Z);

        transform.rotation = Quaternion.RotateTowards( transform.rotation, roationEnemy, rotationSpeed * Time.deltaTime );

    }
}
