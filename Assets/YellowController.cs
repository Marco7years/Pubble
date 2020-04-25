using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowController : MonoBehaviour
{
    public float speed = 0.5f;
    private int interval = 1;
    private float nextTime = 0;

    Rigidbody2D rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // movementBubble();
        rigidBody.AddForce(new Vector2(-1.0f, 0));
    }

    void movementBubble()
    {
        // float number = Random.value;

        /* if (number > 0.5)
         {
             transform.Translate(5 * Vector3.up * Time.deltaTime);
             transform.Translate(5 * Vector3.right * Time.deltaTime);
         }
         else
         {
             transform.Translate(5 * Vector3.up * Time.deltaTime);
             transform.Translate(5 * Vector3.left * Time.deltaTime);
         }*/

        
    }
}
