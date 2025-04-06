using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour
{
    Rigidbody2D _rigidbody2D;
    float randomSpeed;
    float randomFallSpeed;
    float randomAngle;
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        randomSpeed = Random.Range(10f, 30f);
        randomAngle = Random.Range(0f, 10f);
        float angle = randomAngle * Mathf.Rad2Deg;
        _rigidbody2D.transform.rotation = Quaternion.Euler(0, 0, (randomAngle));

    }
    //                                 |
    //  AWESOME MAGIC/LIGHTNING EFFECT \/
    void FixedUpdate()
    {

        _rigidbody2D.velocity = -transform.up * randomSpeed;

    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
