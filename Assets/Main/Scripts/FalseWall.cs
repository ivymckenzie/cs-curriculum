using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalseWall : MonoBehaviour
{
    private CaveMovement cm;
    
    void Start()
    {
        cm = FindObjectOfType<CaveMovement>();
    }
    
    void Update()
    {
        //TEST
        print(cm.plyrAtttack);
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (cm.plyrAtttack)
            {
                Destroy(gameObject);
            }
            
        }
    }
}
