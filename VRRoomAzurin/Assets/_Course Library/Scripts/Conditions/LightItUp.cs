using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightItUp : MonoBehaviour
{
    public ParticleSystem particle;
    public GameObject gameOb;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == gameOb)
        {
            particle.Play();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
