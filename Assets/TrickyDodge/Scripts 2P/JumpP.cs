using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JumpP : MonoBehaviour, IPointerDownHandler
{
    public float upForce = 2400f;
    public GameObject chr;

    private Rigidbody rb;
    private Animator anim;

    void Start()
    {
        rb = chr.GetComponent<Rigidbody>();
        anim = chr.GetComponent<Animator>();
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        if (!GameControlerf2.Instance.isGameOver && !GameControlerf2.Instance.isJumping && !GameControlerf2.Instance.isCroushing)
        {
            jump();
        }
    }
    public void jump()
    {
        GameControlerf2.Instance.isJumping = true;
        anim.SetTrigger("Jump");
        rb.velocity = Vector3.zero;
        rb.AddForce(new Vector3(0, upForce, 0));
        Invoke("Afterjump", 1.7f);
    }
    void Afterjump()
    {
        GameControlerf2.Instance.isJumping = false;
    }
}
