using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BossHitbox : MonoBehaviour
{
    public CaveMovement cm;
    private float bossHealth;
    private bool bossDead;
    
    public static BossHitbox bh;

    private float bossHealthTimer;
    void Start()
    {
        cm = FindObjectOfType<CaveMovement>();
        bossHealth = 5;

        bossHealthTimer = 0;
    }
    
    void Update()
    {
        if (bossHealthTimer > 0)
        {
            bossHealthTimer -= 1 * Time.deltaTime;
        }
        if (bossHealth <= 0)
        {
            bossDead = true;
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (cm.plyrAtttack && bossHealthTimer <= 0)
            {
                bossHealth -= 1;
                bossHealthTimer = 2;
            }
        }
    }
}
