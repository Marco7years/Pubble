using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{

    private BoxCollider2D groundCollider;
    private float groundHorizontalLength;


    private void Awake()
    {
        groundCollider = GetComponent<BoxCollider2D>();

        groundHorizontalLength = groundCollider.size.y;
    }

    private void Update()
    {

        if (transform.position.y < -groundHorizontalLength)
        {

            RepositionBackground();
        }
    }


    private void RepositionBackground()
    {
        
        Vector2 groundOffSet = new Vector2(0, groundHorizontalLength * 2f);

        transform.position = (Vector2)transform.position + groundOffSet;
    }
}
