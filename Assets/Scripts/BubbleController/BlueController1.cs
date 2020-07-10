using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueController1 : MonoBehaviour
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

    }

    private void FixedUpdate()
    {
        Vector3 direction = new Vector3(0, 1.0f, 0);
        transform.position += direction * Time.deltaTime * speed;
    }



}
