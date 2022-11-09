using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   public float maxSpeed = 10f;
   private bool flipRight= true;

   void Update()
   {
    float move = Input.GetAxis("Horizontal");
    GetComponent<Rigidbody2D>().velocity = new Vector2(move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
    if (move > 0 && !flipRight)
    {
        Flip();
    }

    else if (move < 0 && !flipRight)
    {
        Flip();
    }
   }

    private void Flip()
    {
        flipRight = !flipRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
