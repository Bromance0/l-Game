using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public Transform enemyTrans;
    void Start()
    {
        
    }

    void Update()
    {
        if (enemyTrans != null)
        {
            Vector3 enemyPos = enemyTrans.position;
            enemyPos.z = transform.position.z;

            transform.position = enemyPos;
        }
    }
}
