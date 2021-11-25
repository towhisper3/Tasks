using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eagle : Enemy
{
    public Transform uppoint, downpoint;
    private float yUp, yDown;
    public float speed;
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        yUp = uppoint.transform.position.y;
        yDown = downpoint.transform.position.y;
        Destroy(uppoint.gameObject);
        Destroy(downpoint.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    void Movement()
    {
        if (transform.position.y > yUp)
        {
            rb.velocity = new Vector2(rb.velocity.x, -speed);
        }
        else if (transform.position.y < yDown)
        {
            rb.velocity = new Vector2(rb.velocity.x, speed);
        }
    }

}
