using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D _rb;
    public int speedX = 10;
    public int speedY = 10;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();

    }
    public void FixedUpdate()
    {
        /*
        Vector3 mousePosition = Input.mousePosition;
        Vector3 mousePositionInWorld = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector3 directionFromPlayerToMouse = mousePositionInWorld - transform.position;

        float radiansToMouse = Mathf.Atan2(directionFromPlayerToMouse.y, directionFromPlayerToMouse.x);
        float angleToMouse = radiansToMouse * Mathf.Rad2Deg;
        transform.position = mousePositionInWorld;
        */

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            _rb.AddForce(Vector2.down * speedY * Time.deltaTime, ForceMode2D.Impulse); 
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
        }
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
