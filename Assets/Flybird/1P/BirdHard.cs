using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdHard : MonoBehaviour
{
    public float upForce = 200f;
    public bool isDead = false;

    private Rigidbody2D rb2d;
    private Animator anim;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead) { return; }
    }

    void OnCollisionEnter2D()
    {

        isDead = true;
        rb2d.velocity = Vector2.zero;
        anim.SetTrigger("Die");
        GameControllerHardFor1.Instance.Die();
        
    }
    public void fly()
    {
        rb2d.velocity = Vector2.zero;
        rb2d.AddForce(new Vector2(0, upForce));
        anim.SetTrigger("Flap");
    }
}
