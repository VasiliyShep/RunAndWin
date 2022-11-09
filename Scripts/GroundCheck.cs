using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public bool isGround = false;

   void OnTriggerEnter2D(Collider2D other)
   {
    if(other.tag == "Ground")
    {
        isGround = true;
    }
   }

   void OnTriggerExit2D(Collider2D other)
   {
    if(other.tag == "Ground")
    {
        isGround = false;
    }
   }
}
