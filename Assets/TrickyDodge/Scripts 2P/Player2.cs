using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2 : MonoBehaviour
{
    public float upForce = 400f;
    public bool isDead = false;
    public GameObject chr;
    public Button cbut;
    public Button jbut;
    public Button cbut2;
    public Button jbut2;

    private Rigidbody rb;
    private BoxCollider cl;
    private Animator anim;
    private bool isJumping = false;
    private bool iscrouhing = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        cl = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameControlerf2.Instance.isGameOver)
        {
            rb.velocity = Vector3.zero;
            anim.SetTrigger("Dead");
            Destroy(gameObject);
        }
        else
        {
            chr.transform.rotation = Quaternion.Euler(0, 90f, 0);
            rb.velocity = new Vector3(0.1f, rb.velocity.y, 0);
        }
        if (!GameControlerf2.Instance.isSwitch)
        {
            if (Input.GetKeyDown(KeyCode.W) && !isJumping && !iscrouhing)
            {
                Jump();
            }
            if (Input.GetKeyDown(KeyCode.S) && !isJumping && !iscrouhing)
            {
                Chroch();
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.W) && !isJumping && !iscrouhing)
            {
                Chroch();
            }
            if (Input.GetKeyDown(KeyCode.S) && !isJumping && !iscrouhing)
            {
                Jump();
            }
        }
    }
    public void Jump()
    {
        isJumping = true;
        anim.SetTrigger("Jump");
        rb.velocity = Vector3.zero;
        rb.AddForce(new Vector3(0, upForce, 0));
        jbut2.interactable = false;
        cbut2.interactable = false;
        jbut.interactable = false;
        cbut.interactable = false;
        Invoke("Afterjump", 1.7f);
    }
    void Afterjump()
    {
        jbut2.interactable = true;
        cbut2.interactable = true;
        jbut.interactable = true;
        cbut.interactable = true;
        isJumping = false;
    }
    public void Chroch()
    {
        iscrouhing = true;
        anim.SetTrigger("Crouch");
        cl.size += new Vector3(0, -2.88f, 0);
        rb.AddForce(new Vector3(0, -upForce, 0));
        cbut2.interactable = false;
        jbut2.interactable = false;
        cbut.interactable = false;
        jbut.interactable = false;

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
        cbut2.interactable = true;
        jbut2.interactable = true;

        cbut.interactable = true;
        jbut.interactable = true;
        iscrouhing = false;
    }
}
