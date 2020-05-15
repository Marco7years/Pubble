using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseDownController : MonoBehaviour
{
    [SerializeField] ParticleSystem explosion;

    private void OnMouseDown()
    {
        explosion.Play();
        Destroy(gameObject);
    }
}
