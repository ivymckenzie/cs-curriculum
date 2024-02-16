using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalPlatform1 : MonoBehaviour
{
    private float yDirection;


    private float switchTimer = 6;
    void Start()
    {
        yDirection = 2;
    }
    
    void Update()
    {
        transform.position = transform.position + new Vector3(0, yDirection*Time.deltaTime,0);
        if (switchTimer > 0)
        {
            switchTimer -= 1 * Time.deltaTime;
        }
        else
        {
            yDirection = -yDirection;
            switchTimer = 6;
        }
    }
    
}

