using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseDownController : MonoBehaviour
{

    [SerializeField] ParticleSystem explosion;

     private void Awake ()
    {
        explosion = GetComponentInChildren<ParticleSystem> ();
    }

    private void OnMouseDown()
    {
        explosion.Play();
        Destroy(gameObject);
    }
}
