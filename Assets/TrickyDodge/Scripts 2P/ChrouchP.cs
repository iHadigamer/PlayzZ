using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChrouchP : MonoBehaviour, IPointerDownHandler
{
    public float upForce = 2400f;
    public GameObject chr;

    private Rigidbody rb;
    private Animator anim;
    private BoxCollider cl;

    void Start()
    {
        rb = chr.GetComponent<Rigidbody>();
        anim = chr.GetComponent<Animator>();
        cl = chr.GetComponent<BoxCollider>();
    }
    public void Chroch()
    {
        GameControlerf2.Instance.isCroushing = true;
        anim.SetTrigger("Crouch");
        cl.size += new Vector3(0, -2.88f, 0);
        rb.AddForce(new Vector3(0, -upForce, 0));

        Invoke("Aftercrouch", 1.5f);
    }
    void Aftercrouch()
    {
        cl.size += new Vector3(0, +2.88f, 0);
        rb.AddForce(new Vector3(0, 100f, 0));
        Invoke("Aftercrouch2", 0.2f);
    }
    void Aftercrouch2()
    {
        GameControlerf2.Instance.isCroushing = false;
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        if (!GameControlerf2.Instance.isGameOver && !GameControlerf2.Instance.isJumping && !GameControlerf2.Instance.isCroushing)
        {
            Chroch();
        }
    }
}
