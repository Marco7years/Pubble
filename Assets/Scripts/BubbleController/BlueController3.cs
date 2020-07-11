using System.Collections;
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



}
