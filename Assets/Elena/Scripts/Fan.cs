using System;
using UnityEngine;

public class Fan : MonoBehaviour
{

    private bool inRange;
    public GameObject Wind;

    private float shootCooldown;
    public float cooldown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        shootCooldown -= Time.deltaTime;
        if (shootCooldown <= 0)
        {
            if (inRange = true)
            {
                Instantiate(Wind, transform.position, transform.rotation);

                shootCooldown = cooldown;
            }
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inRange = false;
        }
    }

   
}
