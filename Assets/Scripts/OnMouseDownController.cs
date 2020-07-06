using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseDownController : MonoBehaviour
{
    public ParticleSystem explosionEffect;
    private ParticleSystem explosion;


    private void OnMouseDown()
    {
        GameControl.instance.BubbleScore();
        Destroy(gameObject);
        ManageParticleSystem();
    }

    private void ManageParticleSystem()
    {
        explosion = Instantiate(explosionEffect) as ParticleSystem;
        explosion.transform.position = transform.position;
        explosion.Play();
    }


}
