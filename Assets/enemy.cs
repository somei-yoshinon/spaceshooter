﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
      
    }

// Update is called once per frame
void Update()
{
        transform.Rotate( 1f, 1f, 1f );
    transform.Translate( 0, 0, -speed * Time.deltaTime );
        if (transform.position.z > 30) {
         //   Destroy( GameObject );
        }

        }
   // private void OnColisionEnter(Colision colision) {
     //   if (colision.gameObject.tag == "enemy") {
       //     Destroy(enemy);
        //}
    //}
}
    
