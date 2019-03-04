using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletRemove : MonoBehaviour
{
    public float timer = 3f;

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0 )
        {
            Destroy(gameObject);
        }
    }
}
