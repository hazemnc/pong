using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvement : MonoBehaviour
{
     public float speed = 30;
    public string axis;
   
    private void FixedUpdate()
    {
        float v = Input.GetAxisRaw("Vertical") * speed;
        GetComponent<Rigidbody2D>().velocity = new Vector2 (0,v);
    }

   
}
