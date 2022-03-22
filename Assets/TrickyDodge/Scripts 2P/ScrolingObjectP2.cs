using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrolingObjectP2 : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(GameControlerf2.Instance.scrollSpeed, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameControlerf2.Instance.isGameOver)
        {
            rb.velocity = Vector3.zero;
        }
    }
}
