using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearingBridge : MonoBehaviour
{
    private float disappearTimer;
    private bool isDisappearing;
    void Start()
    {
        disappearTimer = 1;
    }


    void Update()
    {
        if (isDisappearing)
        {
            disappearTimer -= 4 * Time.deltaTime;
        }

        if (disappearTimer <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isDisappearing = true;
        }
    }
}
