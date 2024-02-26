using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    private SpriteRenderer chestSprite;
    public Sprite openChest;

    private bool chestOpen;
    private GameObject coin;
    private float offset;
    void Start()
    {
        chestSprite = gameObject.GetComponent<SpriteRenderer>();
    
    }
    
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            chestSprite.sprite = openChest;
            chestOpen = true;
            Destroy(gameObject);
            Instantiate(coin, transform.position , transform.rotation);
        }
    }
}
