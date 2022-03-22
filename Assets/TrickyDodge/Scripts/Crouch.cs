using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Crouch : MonoBehaviour, IPointerDownHandler
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
        Gamecontroler.Instance.isCroushing = true;
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
        Gamecontroler.Instance.isCroushing = false;
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        if (!Gamecontroler.Instance.isGameOver && !Gamecontroler.Instance.isJumping && !Gamecontroler.Instance.isCroushing)
        {
            Chroch();
        }
    }
}
