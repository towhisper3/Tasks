using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOOM : MonoBehaviour
{
    private Rigidbody2D rb;
    private CircleCollider2D cd;
    public LayerMask ground;
    private Animator anim;
    public AudioSource boomAudio;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cd = GetComponent<CircleCollider2D>();
        anim = GetComponent<Animator>();
        boomAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        texting();
    }

    void texting()
    {
        if (rb.IsTouchingLayers(ground))
        {
            // boomAudio.Play();
            anim.SetBool("boom", true);
           
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemies")
        {
            Enemy enemy = collision.gameObject.GetComponent<Enemy>();
            enemy.Death();
            boomAudio.Play();
            anim.SetBool("boom", true);
        }
    }
    void destroy()
    {
        Destroy(gameObject);
    }
}
