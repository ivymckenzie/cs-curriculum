using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawnPoint : MonoBehaviour
{
    private float xDirection;
    private bool switchDirectionR;
    private bool switchDirectionL;

    public float raylength;

    private float switchTimer = 6;
    void Start()
    {
        xDirection = 2;
    }
    
    void Update()
    {
        transform.position = transform.position + new Vector3(xDirection*Time.deltaTime, 0,0);
        if (switchTimer > 0)
        {
            switchTimer -= 1 * Time.deltaTime;
        }
        else
        {
            xDirection = -xDirection;
            switchTimer = 6;
        }
    }

}
