﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecketPlayer1 : MonoBehaviour
{
    public float movemetnSpeed=200f;

    private void FixedUpdate()
    {
        float v = Input.GetAxisRaw("Vertical");
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * movemetnSpeed;
    }
   
}
