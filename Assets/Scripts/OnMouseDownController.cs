using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseDownController : MonoBehaviour
{
    private ParticleSystem explosion;

     private void Awake()
     {
        explosion = GetComponentInChildren<ParticleSystem> ();
     }

    private void OnMouseDown()
    {
        explosion.Play();
        Destroy(gameObject);
    }
}