using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotationRate;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.0f, 0.0f, rotationRate);
    }
}
