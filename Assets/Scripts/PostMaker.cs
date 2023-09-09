using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostMaker : MonoBehaviour
{
    public int numPosts;
    private float floorWidth;
    private float postGap;
    private float leftSide;
    
    public GameObject post;
    private float postHeight;
    private Vector2 postPosition;

    public GameObject colliderOnBox;
    private Vector2 colliderOnBoxPosition;

    // Start is called before the first frame update
    void Start()
    {
        floorWidth = transform.localScale.x;
        leftSide = transform.position.x - (floorWidth / 2);
        postGap = floorWidth / numPosts;
        postHeight = post.transform.localScale.y;
        for (int i = 0; i < numPosts; i++)
        {
            postPosition = new Vector2(leftSide + i * postGap, transform.position.y + postHeight / 2);
            Instantiate(post, postPosition, transform.rotation);
        }
        colliderOnBoxPosition = new Vector2(transform.position.x, transform.position.y + postHeight);
        Instantiate(colliderOnBox, colliderOnBoxPosition, transform.rotation);
    }
}
