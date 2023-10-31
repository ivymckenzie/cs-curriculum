using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    private float _turretTimer = 0;
    [SerializeField] public GameObject EnemyProjectile;
    private GameObject player;

    void Start()
    {
        
    }
    
    void Update()
    {
        if (_turretTimer <= 0)
        {
            if (player != null)
            {
                Instantiate(EnemyProjectile, transform.position, transform.rotation);
                _turretTimer = 3;
            }
        }
        else
        {
            _turretTimer -= Time.deltaTime;
        } 
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player = other.gameObject;
        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player = null;
        }
    }
}
