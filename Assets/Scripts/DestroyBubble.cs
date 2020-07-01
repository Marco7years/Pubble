using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBubble : MonoBehaviour
{
    private ParticleSystem explosion;

    private void Start()
    {
        explosion = this.gameObject.GetComponent<ParticleSystem>();
    }

    void OnBecameInvisible()
    {    
        Destroy(gameObject);
        Destroy(explosion);
    }
}
