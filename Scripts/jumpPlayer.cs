using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpPlayer : MonoBehaviour
{
    public GroundCheck gc;
     private Rigidbody2D rb;
    public float jumpForce = 5.0f;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space) && gc.isGround == true)
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }
}
