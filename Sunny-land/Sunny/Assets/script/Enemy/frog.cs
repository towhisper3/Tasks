using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frog : Enemy
{
    public LayerMask Ground;
    public Transform leftpoint, rightpoint;
    private float xleft, xright;
    private bool faceleft = true;
    public float speed;
    public float jumpforce;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();//获取父类的start
        xleft = leftpoint.transform.position.x;
        xright = rightpoint.transform.position.x;
        Destroy(leftpoint.gameObject);
        Destroy(rightpoint.gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        SwitchAnimation();
    }

    void Movement()
    {
        if (faceleft)
        {
            if (rb.IsTouchingLayers(Ground))
            {
                rb.velocity = new Vector2(-speed, jumpforce);
                anim.SetBool("idle", false);
                anim.SetBool("jumping", true);
            }
            if (transform.position.x < xleft)
            {
                transform.localScale = new Vector3(-1, 1, 1);
                faceleft = false;
            }
        }
        else
        {
            if (rb.IsTouchingLayers(Ground))
            {
                rb.velocity = new Vector2(speed, jumpforce);
                anim.SetBool("idle", false);
                anim.SetBool("jumping", true);
            }
            if (transform.position.x > xright)
            {
                transform.localScale = new Vector3(1, 1, 1);
                faceleft = true;
            }
        }
    }
    void SwitchAnimation()
    {
        if (rb.velocity.y < 0)
        {
            anim.SetBool("jumping", false);
            anim.SetBool("falling", true);
        }
        else if (anim.GetBool("falling") && rb.IsTouchingLayers(Ground))
        {
            anim.SetBool("falling", false);
            anim.SetBool("idle", true);
        }
    }
}
