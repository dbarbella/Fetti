using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderActivator : MonoBehaviour
{
    //Collider2D m_Collider;
    Collider2D otherCollider;

    void Awake()
    {
        //m_Collider = GetComponent<Collider2D>();
        Debug.Log("Top Part.");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("In here.");
        if (other.gameObject.tag == "Particle")
        {
            // Move to the collision layer with the posts and other particles.
            other.gameObject.layer = 7;

            Debug.Log("Should be turning on.");

        }
    }
}
