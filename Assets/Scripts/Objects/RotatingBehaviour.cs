using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingBehaviour : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.Rotate(.0f, .1f, .0f, Space.Self);       
    }
}
