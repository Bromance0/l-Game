using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDamage : MonoBehaviour
{

    public int hp = 1;

    float godmode = 0;
    int defaultLayer;

    public float godmodeTimer = 0;

    void Start()
    {
        defaultLayer = gameObject.layer;
    }

    void OnTriggerEnter2D()
    {
        Debug.Log("Trigger!");     
            hp--;
            godmode = godmodeTimer;
            gameObject.layer = 10;
    }

    void Update()
    {
        godmode -= Time.deltaTime;
        if (godmode <= 0 )
        {
            gameObject.layer = defaultLayer;
        }
        if (hp <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
