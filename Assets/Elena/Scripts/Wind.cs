using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    public GameObject player;
    private Vector3 target;
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        target = player.transform.position;
        speed = 4;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed*Time.deltaTime);
    }
}
