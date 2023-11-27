using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretProjectile : MonoBehaviour
{
    public GameObject Player;
    private Vector3 playerPos;


    void Start()
    {
        playerPos = Player.transform.position;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPos, 10 * Time.deltaTime);
    }
}