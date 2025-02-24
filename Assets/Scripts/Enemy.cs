using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class Enemy : MonoBehaviour
{
    Rigidbody2D _rigidbody2D;
    Transform target;
    public float speed = 2;
    Vector2 moveDirection;
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        target = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        target = GameObject.FindWithTag("Player").transform;

        if (target)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            _rigidbody2D.rotation = angle;
            moveDirection = direction;

            _rigidbody2D.velocity = new Vector2(moveDirection.x, moveDirection.y) * speed;

        }
    }
    
    void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.GetComponent<Player>())
        {
            GameoverMenucontroller.instance.ShowGameover2();
        }
    }
}