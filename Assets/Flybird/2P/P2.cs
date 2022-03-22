using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2 : MonoBehaviour
{
    public float upForce = 200f;
    public bool isDead = false;
    public GameObject bird;

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
        GameControllerHard.Instance.Die();
        bird.SetActive(false);
    }
    public void fly()
    {
        rb2d.velocity = Vector2.zero;
        rb2d.AddForce(new Vector2(0, upForce));
        anim.SetTrigger("Flap");
    }
}
