﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueController3 : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb2D;

    private void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        //rb2D.bodyType = RigidbodyType2D.Kinematic;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameControl.instance.score > 10)
            speed = 7.0f;
        if (GameControl.instance.score > 20)
            speed = 9.0f;
        if (GameControl.instance.score > 30)
            speed = 11.0f;
        if (GameControl.instance.score > 40)
            speed = 13.0f;
        if (GameControl.instance.score > 50)
            speed = 17.0f;
        if (GameControl.instance.score > 60)
            speed = 20.0f;
        if (GameControl.instance.score > 70)
            speed = 24.0f;
        if (GameControl.instance.score > 80)
            speed = 27.0f;
    }

    private void FixedUpdate()
    {
        Vector3 direction = new Vector3(0, 1.0f, 0);
        transform.position += direction * Time.deltaTime * speed;
    }


    // Per la collisione delle bolle con la parte alta dello schermo(da modificare)
    /*    void OnCollisionEnter2D(Collision2D other)
    {
        // Zero out the bird's velocity
        rb2d.velocity = Vector2.zero;
        // If the bird collides with something set it to dead...
        isDead = true;
        //...tell the Animator about it...
        anim.SetTrigger ("Die");
        //...and tell the game control about it.
        GameControl.instance.BirdDied ();
    }
    */

}