using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretProjectile : MonoBehaviour
{
    private GameObject Player;
    private Vector3 playerPos;

    private HUD hud;


    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        playerPos = Player.transform.position;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPos, 10 * Time.deltaTime);
        if (transform.position == playerPos)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
    }
}