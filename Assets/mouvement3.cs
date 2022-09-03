using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvement3 : MonoBehaviour
{
    
     public float speed = 30;
    public string axis;
   
    private void FixedUpdate()
    {
        float v = Input.GetAxisRaw("Vertical2") * speed;
        GetComponent<Rigidbody2D>().velocity = new Vector2 (0,v);
    }
}
