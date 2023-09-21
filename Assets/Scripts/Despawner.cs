using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawner : MonoBehaviour
{
    public int lifespanSeconds;

    // Start is called before the first frame update
    void Start()
    {
        // This should really get the framerate from somewhere.
        Destroy(gameObject, lifespanSeconds);
    }
}
