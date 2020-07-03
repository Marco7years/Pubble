﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowController3 : MonoBehaviour
{
    private Rigidbody2D rb2D;
    private float coolDown = -1.0f;
    private float timeToCoolDown = 1.0f;
    [SerializeField] float speed = 2.0f;
    private float horizontal = 0f;

    private void Awake()
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

      
    void onCollisionEnter2D(Collision2D other)
    {
        speed = speed * -1;
        Debug.Log("onCollision2D attivo");
    }

    private void FixedUpdate()
    {
        float vertical = speed * Time.deltaTime;

        if (coolDown < 0)
        {
            coolDown = timeToCoolDown;
            int randomDirection = Random.Range(-1, 1);
            if (randomDirection == 0) randomDirection = 1;
            horizontal = randomDirection * speed * Time.deltaTime;
        }

        Vector3 newPosition = transform.position + new Vector3(horizontal, vertical, 0f);
        rb2D.MovePosition(newPosition);
        coolDown -= Time.deltaTime;
    }

}