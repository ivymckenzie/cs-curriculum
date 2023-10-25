using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public HUD hud; //make this private ?
    private float healthTimer;
    void Start()
    {
        hud = FindObjectOfType<HUD>();
        healthTimer = 0;
    }
    
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Spikes"))
        {
            if (healthTimer <= 0)
            {
                hud.health -= 1;
                healthTimer = 1;
            }
            else
            {
                healthTimer -= Time.deltaTime;
            }
            
            
        }
        else if (other.gameObject.CompareTag("Healing") && hud.health != hud.maxHealth)
        {
            hud.health ++;
            Destroy(other.gameObject);
        }
    }
}
