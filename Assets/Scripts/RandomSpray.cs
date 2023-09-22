using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpray : MonoBehaviour
{
    public int fireDelay;
    private int fireTimer = 0;
    public GameObject ball;
    private Quaternion projectileRotation;

    // Update is called once per frame
    void Update()
    {
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
        projectileRotation = Quaternion.Euler(0f, 0f, Random.Range(-180, 180));
        Instantiate(ball, transform.position, projectileRotation);
    }
}
