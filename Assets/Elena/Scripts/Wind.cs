using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    public GameObject player;
    private Vector3 target;
    public float speed;

    private Rigidbody2D rb;
  
    // Start is called before the first frame update
    void Start()
    {
        target = player.transform.position;
        speed = 4;

        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
        }
    }
}
