using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FlyP : MonoBehaviour, IPointerDownHandler
{
    public float upForce = 200f;
    public GameObject bird;
    private Rigidbody2D rb2d;
    private Animator anim;
    void Start()
    {
        rb2d = bird.GetComponent<Rigidbody2D>();
        anim = bird.GetComponent<Animator>();
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        rb2d.velocity = Vector2.zero;
        rb2d.AddForce(new Vector2(0, upForce));
        anim.SetTrigger("Flap");
    }
}
