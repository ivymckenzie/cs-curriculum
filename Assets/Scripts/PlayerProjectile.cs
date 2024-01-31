using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    private Vector3 target;
    private CaveMovement cm;

    //custom xvectors for movement
    private float xVector;
    private float yVector;
    
    void Start()
    {
        cm = FindObjectOfType<CaveMovement>();
        
        xVector = cm.xDirection * 10 * Time.deltaTime;
        yVector = cm.yDirection * 10 * Time.deltaTime;
    }
    
    void Update()
    {
        transform.position = transform.position + new Vector3(xVector, yVector, 0);
    }

    private void OnTriggerEnter(Collider2D other)
    {
       Destroy(gameObject);
    }
}
