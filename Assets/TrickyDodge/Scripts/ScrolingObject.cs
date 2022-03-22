using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrolingObject : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(Gamecontroler.Instance.scrollSpeed, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Gamecontroler.Instance.isGameOver)
        {
            rb.velocity = Vector3.zero;
        }
    }
}
