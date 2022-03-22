using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackgroung : MonoBehaviour
{
    private BoxCollider groundCollider;
    private float groundHorizontalLength;

    // Use this for initialization
    void Start()
    {
        groundCollider = GetComponent<BoxCollider>();
        groundHorizontalLength = groundCollider.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < (-groundHorizontalLength))
        {
            RepositionBackground();
        }
    }

    private void RepositionBackground()
    {
        Vector3 groundOffset = new Vector3(groundHorizontalLength*2, 0, 0);
        transform.position = (Vector3)transform.position + groundOffset;
    }
}
