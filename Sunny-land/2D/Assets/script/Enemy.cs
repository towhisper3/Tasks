using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    protected Animator anim;

    protected Rigidbody2D rb;
    protected CircleCollider2D cd;

    protected AudioSource boomAudio;
    protected virtual void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        cd = GetComponent<CircleCollider2D>();
        boomAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void Destory()
    {
        Destroy(gameObject);
    }
    public void Death()
    {
        boomAudio.Play();
        anim.SetTrigger("boom");
    }
}
