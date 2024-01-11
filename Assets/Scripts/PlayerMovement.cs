using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CaveMovement : MonoBehaviour
{
    private float xSpeed;
    private float ySpeed;
    
    public float xDirection;
    public float yDirection;
    
    private float xVector;
    private float yVector;

    private double _shootTimer = 0;
    
    private double attackTimer = 0.8;
    public static bool plyrAtttack;

    [SerializeField] public GameObject PlayerProjectile;
    
    public static CaveMovement cm; //logs class (script) 

    public bool overWorld;

    void Start()
    {
        //get scene
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "Start")
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
        // optional; contains perameters for overWorld movement
        if (!overWorld)
        {
            ySpeed = 0;
        }
        else
        {
            ySpeed = xSpeed;
        }
    }

    void Update()
    {
        
        xDirection = Input.GetAxis("Horizontal");
        yDirection = Input.GetAxis("Vertical");
        xVector = xDirection * xSpeed * Time.deltaTime;
        yVector = yDirection * ySpeed * Time.deltaTime;
        transform.position = transform.position + new Vector3(xVector, yVector, 0);
        
        // check if attacking; 1 second delay
        
        if (attackTimer > 0)
        {
            attackTimer = attackTimer - 1 * Time.deltaTime;
        }
        
        if (Input.GetMouseButton(0))
        {
            if (attackTimer <= 0)
            {
                plyrAtttack = true;
                attackTimer = 0.8;
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
}
