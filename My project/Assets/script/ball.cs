using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ball : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    public float jumpForce = 3.0f;
    public float movespeed = 3.0f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalinput = Input.GetAxis("Horizontal");
        Vector2 moveDirection=new Vector2(horizontalinput*movespeed, rb.velocity.y);
        rb.velocity = moveDirection;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            jump();
        }
    }
    void jump()
    {
        rb.velocity = Vector2.up * jumpForce;
    }
}
