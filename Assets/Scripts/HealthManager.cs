using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public HUD hud; 
    private double _healthTimer = 0;
    void Start()
    {
        hud = FindObjectOfType<HUD>();
    }
    
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Spikes") || other.gameObject.CompareTag("Enemy") || other.gameObject.CompareTag("Projectile"))
        {
            if (_healthTimer <= 0)
            {
                hud.health -= 1;
                _healthTimer = 1;
            }
            else
            {
                _healthTimer -= Time.deltaTime;
            }
            
            
        }
        else if (other.gameObject.CompareTag("Healing") && hud.health != hud.maxHealth)
        {
            hud.health ++;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Axe"))
        {
            hud.hasAxe = true;
            Destroy(other.gameObject);
        }
    }
}
