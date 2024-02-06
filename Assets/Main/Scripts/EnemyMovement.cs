using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class EnemyMovement : MonoBehaviour
{
    private CaveMovement cm;
    
    private GameObject Player;
    private Vector3 playerPos;

    private float ehealthTimer;
    private int ehealth = 5;
    
    //drops
    private float enemyDrop = 0;
    public GameObject healthPot;
    public GameObject coin;
    public GameObject axe;
    
    //enemy dmg color
    private Color dmgColor;
    
    //follow
    private bool canChase;
    
    //private Collider startHitbox;
    //private Collider alertHitbox;

    private float chaseSpeed = 0;
    

    void Start()
    {
        ehealthTimer = 1;
        cm = FindObjectOfType<CaveMovement>();
        
        Player = GameObject.FindWithTag("Player");
        dmgColor = gameObject.GetComponentInChildren<Color>();
    }
    
    void Update()
    {
        //TEST
        print(dmgColor);
        
        if (canChase)
        {
            playerPos = Player.transform.position;
            if (chaseSpeed < 5)
            {
                chaseSpeed += 10 * Time.deltaTime;
            }
            transform.position = Vector3.MoveTowards(transform.position,playerPos,chaseSpeed * Time.deltaTime);
        }
        
        
        if (ehealthTimer > 0)
        {
            ehealthTimer = ehealthTimer - 1 * Time.deltaTime;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) // not specific to either hitbox
        {
            canChase = true;
        }
    }

    //damage
    private void OnTriggerStay2D(Collider2D other)
    {
        
        if (other.gameObject.CompareTag("Player") && ehealthTimer <= 0)
        {
            
            ehealth = ehealth - 1;
            ehealthTimer = 1;
            dmgColor = Color.red;
            
            if (ehealth <= 0)
            {
                if (cm.plyrAtttack)
                {
                    if (gameObject.CompareTag("Enemy"))
                    {
                        enemyDrop = Random.Range(0, 100);
                        if (enemyDrop > 25 && enemyDrop < 50)
                        {
                            Instantiate(healthPot, transform.position, transform.rotation);
                        }
                        if (enemyDrop > 50)
                        {
                            Instantiate(coin, transform.position, transform.rotation);
                        }
                        Destroy(gameObject);
                    }

                    else if (gameObject.CompareTag("AxeEnemy"))
                    {
                        Instantiate(axe, transform.position, transform.rotation);
                        Destroy(gameObject);
                    }
                }
            }
        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canChase = false;
            chaseSpeed = 0;
        }
    }
    
}
