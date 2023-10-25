using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    public CoinPurse coinpurse;
    public HealthManager healthmanager;
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI healthText;
    // v game manager stuff v
    public static HUD hud;
    public int health;
    public int coins;
    public int maxHealth;
    
    void Awake()
    {
        if (hud != null && hud != this)
        {
            Destroy(gameObject);
        }
        else
        {
            hud = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    
    
    void Start()
    {
        maxHealth = 5;
        health = maxHealth;
        coins = 0;
    }
    
    void Update()
    {
        coinText.text = "Coins: " + coins.ToString();
        healthText.text = "Health: " + health.ToString();

    }
}
