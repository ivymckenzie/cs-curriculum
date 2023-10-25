using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;



public class CoinPurse : MonoBehaviour
{
    public HUD hud; 
    void Start()
    {
        hud = FindObjectOfType<HUD>();
    }
    
    void Update()
    {
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            hud.coins ++;
            Destroy(other.gameObject);
        }
    }
}
