﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{

     Rigidbody2D rb2d;

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(GameControllerHardFor1.Instance.scrollSpeed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(GameControllerHardFor1.Instance.isGameOver)
        {
            rb2d.velocity = Vector2.zero;
        }
    }

}
