using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossExit : MonoBehaviour
{
    private float disappearTimer;
    private bool isDisappearing;

    public static BossHitbox bh;
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
