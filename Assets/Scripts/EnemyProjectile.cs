using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretProjectile : MonoBehaviour
{
    public GameObject Player;
    private Vector3 target;

    void Start()
    {
        target = Player.transform.position;
    }
    
    void Update()
    {
      Vector3.MoveTowards(transform.position,target,5);
    }
}
