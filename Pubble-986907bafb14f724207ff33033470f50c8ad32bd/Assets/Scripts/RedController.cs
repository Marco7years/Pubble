﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedController : MonoBehaviour
{
    Rigidbody2D rb2D;
    [SerializeField] float speed = 1.0f;
    [SerializeField]float speedHorizontal = 0.2f;
    float coolDown = -1f;
    float timeToCoolDown = 5f;
    float vertical = 1f;
    float direction = 1f;
    

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        rb2D.bodyType = RigidbodyType2D.Kinematic;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = speedHorizontal * Time.deltaTime;
        if(coolDown < 0)
        {
            coolDown = timeToCoolDown;
            vertical = Time.deltaTime * direction * speed;
            direction = direction * -1;
            if(vertical > 0) timeToCoolDown = 3f;
            if (vertical < 0) timeToCoolDown = 5f;
        }

        Vector3 newPosition = transform.position + new Vector3(horizontal, vertical, 0f);
        rb2D.MovePosition(newPosition);
        coolDown -= Time.deltaTime;
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
