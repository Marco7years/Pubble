using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowController : MonoBehaviour
{
    Rigidbody2D rb2D;
    float coolDown = -1.0f;
    float timeToCoolDown = 1.0f;
    [SerializeField] float speed = 2.0f;
    float horizontal = 0f;

    private void Awake()
    {
       rb2D = gameObject.GetComponent<Rigidbody2D>();
       rb2D.bodyType = RigidbodyType2D.Kinematic;
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = speed * Time.deltaTime;
        
        if (coolDown < 0)
        {
            coolDown = timeToCoolDown;
            int randomDirection = Random.Range(-1, 1);
            if(randomDirection == 0) randomDirection = 1;
            horizontal = randomDirection * speed * Time.deltaTime;
        }

        Vector3 newPosition = transform.position + new Vector3(horizontal, vertical, 0f);
        rb2D.MovePosition(newPosition);
        coolDown -= Time.deltaTime;
    }

    private void OnMouseDown()
    {
        this.gameObject.SetActive(false);
    }

      // Per la collisione delle bolle con la parte alta dello schermo(da modificare)
      /*
       * void OnCollisionEnter2D(Collision2D other)
       * {
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
