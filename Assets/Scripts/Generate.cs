using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour
{
    public float rotationRate;
    public int fireDelay;
    private int fireTimer = 0;
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.0f, 0.0f, rotationRate);
        if (fireTimer == fireDelay)
        {
            Fire();
            fireTimer = 0;
        }
        else
        {
            fireTimer += 1;
        }
    }

    void Fire()
    {
        Instantiate(ball, transform.position, transform.rotation);
    }
}
