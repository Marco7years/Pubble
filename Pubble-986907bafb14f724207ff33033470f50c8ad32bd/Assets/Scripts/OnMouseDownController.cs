using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseDownController : MonoBehaviour
{
    public ParticleSystem explosionEffect;

    private void OnMouseDown()
    {
        Destroy(gameObject);
        ParticleSystem explosion = Instantiate(explosionEffect) as ParticleSystem;
        explosion.transform.position = transform.position;
        explosion.Play();
    }
}
