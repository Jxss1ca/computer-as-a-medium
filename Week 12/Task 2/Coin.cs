using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private float waitTimer = 4f;
    private float middleLimit = 1f;

    void Update()
    {
        CoinMovement();
    }

    void CoinMovement()
    {
        transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * 3f);

        if (transform.position.y <= middleLimit && waitTimer > 0f)
        {
            transform.position = new Vector3(transform.position.x, middleLimit, 0);
            waitTimer -= Time.deltaTime;
        }

        if (transform.position.y <= -7f)
        {
            Destroy(this.gameObject);
        }
    }
}