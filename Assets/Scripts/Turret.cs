using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    private float turretTimer = 0;
    public GameObject Turret_Projectile;
    public GraphicsBuffer.Target Target;

    void Start()
    {
        
    }
    
    void Update()
    {
        if (turretTimer <= 0)
        {
            if (Target != null)
            {
                Instantiate(Turret_Projectile);
                turretTimer = 3;
            }
        }
        else
        {
            turretTimer -= Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(CircleCollider2D other)
    {
        //if (other.gameObject.CompareTag("Player"))
        //{
           // Target = null;
            //erm
      //  }
    }
}
