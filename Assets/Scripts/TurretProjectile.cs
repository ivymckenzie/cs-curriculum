using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretProjectile : MonoBehaviour
{
    private GameObject Player;
    private Vector3 playerPos;
    
    private Vector3 upd8PlayerPos;

    private HUD hud;


    void Start()
    {
        hud = FindObjectOfType<HUD>();
        
        Player = GameObject.FindWithTag("Player");
        playerPos = Player.transform.position;
    }

    void Update()
    {
        upd8PlayerPos = Player.transform.position;
        
        transform.position = Vector3.MoveTowards(transform.position, playerPos, 10 * Time.deltaTime);
        //stops when it arrives player's sensed position...???
        
        if (transform.position == upd8PlayerPos) // too precise to actually work but idk how hitboxes work with instantiated objs so
        {
            hud.health -= 1;
            Destroy(gameObject);
        }
    }
    
}