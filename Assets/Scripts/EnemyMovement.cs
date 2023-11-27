using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject Player;
    private Vector3 playerPos;

    void Start()
    {
        
    }
    
    void Update()
    {
        playerPos = Player.transform.position;
        Vector3.MoveTowards(transform.position,playerPos,5000);
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
