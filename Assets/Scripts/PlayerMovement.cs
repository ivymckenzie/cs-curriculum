using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vector3 = UnityEngine.Vector3;

public class CaveMovement : MonoBehaviour
{
    private HUD hud;
    
    private float xSpeed;
    private float ySpeed;
    
    public float xDirection;
    public float yDirection;
    public float jumpPressed;
    
    private float xVector;
    private float yVector;

    private double _shootTimer = 0;
    
    private double attackTimer = 0.8;
    public bool plyrAtttack;

    [SerializeField] public GameObject PlayerProjectile;
    
    public static CaveMovement cm; //logs class (script) 

    public bool overWorld;
    
    //jump
    private bool canJump;
    private Rigidbody2D plyrRB;
    

    void Start()
    {
        //get scene
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        

        if (sceneName == "Start" || sceneName == "Platformer")
        {
            overWorld = false;
        }
        else if (sceneName == "Overworld")
        {
            overWorld = true;
        }

        int buildIndex = currentScene.buildIndex;
        switch (buildIndex)
        {
            
        }
        
        //movement
        xSpeed = 6;
        if (overWorld)
        {
            ySpeed = xSpeed;
        }
        plyrRB = GetComponent<Rigidbody2D>();


    }

    void Update()
    {
        
        xDirection = Input.GetAxis("Horizontal");
        yDirection = Input.GetAxis("Vertical");
        jumpPressed = Input.GetAxis("Vertical");
        
        xVector = xDirection * xSpeed * Time.deltaTime;
        yVector = yDirection * ySpeed * Time.deltaTime;
        
        
        if (!overWorld)
        {
            if (jumpPressed > 0 && canJump == true)
            {
                plyrRB.velocity = new Vector3(plyrRB.velocity.x, 6, 0);
            }
            
        }
        
        transform.position = transform.position + new Vector3(xVector, yVector, 0);
        
        
        
        // check if attacking; 1 second delay
        if (attackTimer > 0)
        {
            attackTimer = attackTimer - 1 * Time.deltaTime;
        }
        if (Input.GetMouseButton(0))
        {
            if (attackTimer < 0)
            {
                plyrAtttack = true;
                
            }
            else
            {
                plyrAtttack = false;
            }
        }
        
        

        if (_shootTimer <= 0)
        {
            if (Input.GetMouseButton(1))
            {
                Instantiate(PlayerProjectile, transform.position, transform.rotation);
                _shootTimer = 0.5;
            }
        }
        else
        {
            _shootTimer -= Time.deltaTime;
        }
        
        
    
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (!overWorld)
        {
            if (other.gameObject.CompareTag("PlatformCollision"))
            {
                canJump = false;
            }

            if (other.gameObject.CompareTag("Gate"))
            {
                if (hud.hasAxe)
                {
                    Destroy(other.gameObject);
                    print("YAY");
                }
                
            }
        }
        
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (!overWorld && other.gameObject.CompareTag("PlatformCollision"))
        {
            canJump = true;
        }
    }
}
