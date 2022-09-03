using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 void OnCollisionEnter2D(OnCollisionEnter2D col)
{
    float scoreright, scoreleft;
    if(col.GameObject.name == wallright){
   float y = hitfactor(transform.position,
                        col.transform.position,
                        col.colider.bounds.size.y);
    Vector2 dir = new Vector2(1,y).normalized;
    GetComponent<Rigidbody2D>().velocity = dir * speed;
    scoreleft++;
    scoreleftText.text = scoreleft.ToString;}
    if(col.GameObject.name == wallleft){
        float y = hitfactor(transform.position,
                            col.transform.position,
                            col.colider.bounds.size.y);
    Vector2 dir = new Vector2(-1,y).normalized;
    GetComponent<Rigidbody2D>().velocity = dir* speed;
    scoreright++ ; 
    scorerighttext.text = scoreright.ToString();                      
    }
}
