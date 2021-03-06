﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float speed;
    float horz, vert;

    void Start()
    {
        speed = 10;
    }
    
    void Update()
    {

        horz = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");

        vert *= Time.deltaTime * speed;
        horz *= Time.deltaTime * speed;

        transform.Translate(horz, vert, 0);
        
    }
}
