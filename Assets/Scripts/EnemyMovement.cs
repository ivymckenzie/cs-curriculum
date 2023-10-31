using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    void Start()
    {

    }
    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // turn alert collider trigger on
    }
    private void OnTriggerStay(Collider other)
    {
        // follow player
    }
    private void OnTriggerExit(Collider other)
    {
        // turn alert collider trigger off
    }
}
