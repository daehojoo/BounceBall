using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceSensor : MonoBehaviour
{
    Rigidbody2D rb;

    private void Start()
    {
        rb = this.gameObject.transform.parent.GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (this.gameObject.name == "down")
        {
            rb.velocity = new Vector2(0, 6);
            rb.gravityScale = 1f;

        }
        if (this.gameObject.name == "up")
        {
            rb.velocity = new Vector2(0, -6);
            rb.gravityScale = 1f;
        }
        if (this.gameObject.name == "right")
        {
            rb.velocity = new Vector2(-2, 0);
            rb.gravityScale = 1f;
        }
        if (this.gameObject.name == "left")
        {
            rb.velocity = new Vector2(2, 0);
            rb.gravityScale = 1f;
        }



    }










}
