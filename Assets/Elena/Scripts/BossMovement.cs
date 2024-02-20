using System;
using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;
using Random = UnityEngine.Random;

public class Boss : MonoBehaviour
{
    public float speed;
    private float DirectionChangeChance;

    private Vector2 moveDirection;
    private Rigidbody2D rb;

    private RaycastHit2D hit;
    public float raylength;

    private float fallingrocks;

    private GameObject rock;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveDirection = Random.insideUnitCircle.normalized;

    }

    // Update is called once per frame
    void Update()
    {
      
       hit = Physics2D.Raycast(transform.position, moveDirection, raylength);
       
       if (hit)
       {
           moveDirection = Random.insideUnitCircle.normalized;
           fallingrocks = Random.Range(1, 4);
       }

       if (fallingrocks == 1)
       {
           Instantiate(rock, transform.position, transform.rotation);
       }

       if (fallingrocks > 1)
       {
           
       }
      
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveDirection * speed * Time.deltaTime);
    }
}
