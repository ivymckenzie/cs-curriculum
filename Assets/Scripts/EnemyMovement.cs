using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class EnemyMovement : MonoBehaviour
{
    public GameObject Player;
    private Vector3 playerPos;

    private float ehealthTimer;
    private int ehealth = 2;
    
    //drops
    private float enemyDrop = 0;
    public GameObject healthPot;
    public GameObject coin;
    
    

    void Start()
    {
        ehealthTimer = 1;
    }
    
    void Update()
    {
        playerPos = Player.transform.position;
        Vector3.MoveTowards(transform.position,playerPos,5000);
        
        if (ehealthTimer > 0)
        {
            ehealthTimer = ehealthTimer - 1 * Time.deltaTime;
        }
        
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // turn alert collider trigger on
    }
    private void OnTriggerStay(Collider other)
    {
        // follow player
    }
    private void OnTriggerExit(Collider other)
    {
        // turn alert collider trigger off
    }
    
    //damage
    private void OnTriggerStay2D(Collider2D other)
    {
            if (other.gameObject.CompareTag("Player"))
            {
                //make sure to add if plyrAttack == true l8r bc it aint working & enemy following
                if (ehealthTimer <= 0)
                {
                    ehealth = ehealth - 1;
                    ehealthTimer = 1;
                    if (ehealth <= 0)
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
                }
            }
        
    }
}
