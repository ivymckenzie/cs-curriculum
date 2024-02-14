using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SidewaysPlatform : MonoBehaviour
{
    private float xDirection;
    private bool switchDirectionR;
    private bool switchDirectionL;

    public float raylength;
    
    void Start()
    {
        xDirection = 2;
    }
    
    void Update()
    {
        transform.position = transform.position + new Vector3(xDirection*Time.deltaTime, 0,0);
        
        //raycast
        switchDirectionR = Physics2D.Raycast(transform.position, Vector2.right, raylength);
        if (switchDirectionL || switchDirectionR)
        {
            xDirection = -xDirection;
        }
        
        
    }
    
}

