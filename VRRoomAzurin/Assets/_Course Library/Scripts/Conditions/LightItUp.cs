using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightItUp : MonoBehaviour
{
    public ParticleSystem particle;
    public GameObject gameOb;

    private void Awake()
    {
        particle.Stop();
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == gameOb)
        {
            particle.Play();
        }
    }
}
