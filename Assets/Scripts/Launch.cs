using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    private float zAngle;
    private float xThrust;
    private float yThrust;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        
        zAngle = transform.eulerAngles.z * Mathf.Deg2Rad;
        xThrust = -Mathf.Sin(zAngle);
        yThrust = Mathf.Cos(zAngle);
        rb.AddForce(new Vector2(xThrust, yThrust) * speed);
    }
}
