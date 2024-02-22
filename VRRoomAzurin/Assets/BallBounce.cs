using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;

    private void OnCollisionEnter(Collision collision)
    {
       if (collision != null)
        {
            audioSource.PlayOneShot(audioClip);
        }
    }
}
