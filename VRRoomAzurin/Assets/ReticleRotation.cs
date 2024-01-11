using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ReticleRotation : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(0f, 3f, 0f, Space.World);
    }
}
