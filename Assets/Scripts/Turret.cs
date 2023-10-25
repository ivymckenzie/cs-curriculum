using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    private float _turretTimer = 0;
    public GameObject Turret_Projectile;
    public GameObject target;

    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    private void OnTriggerStay2D(CircleCollider2D other)
    {
        if (_turretTimer <= 0)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                Instantiate(Turret_Projectile, transform.position, transform.rotation);
                _turretTimer = 3;
            }
        }
        else
        {
            _turretTimer -= Time.deltaTime;
        }
        
    }
}
