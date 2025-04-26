using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D _rb;
    public int speedX = 10;
    public int speedY = 10;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();

    }
    
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            _rb.AddForce(-transform.right * speedX * Time.deltaTime, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            _rb.rotation += 2.0f;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            _rb.rotation -= 2.0f;
        }

        if (GameoverMenucontroller.instance.gameoverhappened == true)
        {
            Time.timeScale = 0;
            return;
        }
        /*
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            _rb.AddForce(Vector2.down * speedY * Time.deltaTime, ForceMode2D.Impulse);
            _rb.rotation += 4.0f;
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            _rb.AddForce(Vector2.left * speedX * Time.deltaTime, ForceMode2D.Impulse);
            
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            _rb.AddForce(Vector2.right * speedX * Time.deltaTime, ForceMode2D.Impulse);
            
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            _rb.AddForce(Vector2.up * speedX * Time.deltaTime, ForceMode2D.Impulse);
            _rb.rotation -= 4.0f;
        }
        */
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Point")
        {
            Gamecontroller.instance.Addpoints(1);
            collision.gameObject.SetActive(false);
        }
    }
}
