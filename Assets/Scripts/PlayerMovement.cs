using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CaveMovement : MonoBehaviour
{
    private float xSpeed;
    private float ySpeed;
    
    private float xDirection;
    private float yDirection;
    
    private float xVector;
    private float yVector;

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
        
    }
}
