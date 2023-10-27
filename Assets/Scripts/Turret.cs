using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    private float _turretTimer = 0;
    public GameObject EnemyProjectile;
    private GameObject target;

    void Start()
    {
        
    }
    
    void Update()
    {
        if (_turretTimer <= 0)
        {
            if (target != null)
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

    private void OnTriggerEnter2D(CircleCollider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            target = other.gameObject;
        }
    }
    
    private void OnTriggerExit2D(CircleCollider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            target = null;
        }
    }
}
