using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float maxSpeed = 10f;
    float rotationSpeed = 300f;

    float bounds = 0.5f;


    void Start()
    {
        
    }

 
    void Update()
    {
        Quaternion rotation = transform.rotation;

        float z = rotation.eulerAngles.z;

        z -= Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;

        rotation = Quaternion.Euler(0, 0, z);

        transform.rotation = rotation;

        Vector3 position = transform.position;

        Vector3 acce = new Vector3(0, Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime, 0);

        position += rotation * acce;

        if (position.y+bounds > Camera.main.orthographicSize)
        {
            position.y = Camera.main.orthographicSize - bounds;
        }
        if (position.y - bounds < -Camera.main.orthographicSize)
        {
            position.y = -Camera.main.orthographicSize + bounds;
        }


        float screenBorders = (float)Screen.width / (float)Screen.height;
        float endBorders = Camera.main.orthographicSize * screenBorders;

        if (position.x + bounds > endBorders)
        {
            position.x = endBorders - bounds;
        }

        if (position.x - bounds < -endBorders)
        {
            position.x = -endBorders + bounds;
        }
        
        transform.position = position;
    }
}
