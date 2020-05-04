using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleController : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(0,1.0f,0);
        transform.position += direction * Time.deltaTime * speed;
    }

    private void OnMouseDown()
    {
        this.gameObject.SetActive(false);
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
