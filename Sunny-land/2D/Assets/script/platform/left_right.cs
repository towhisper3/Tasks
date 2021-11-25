using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class left_right : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    public Transform leftpoint, rightpoint;
    private float xleft, xright;
    public float speed;
    void Start()
    {
        xleft = leftpoint.transform.position.x;
        xright = rightpoint.transform.position.x;
        Destroy(leftpoint.gameObject);
        Destroy(rightpoint.gameObject);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement(); 
    }
    void Movement()
    {
        if (transform.position.x < xleft)
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }else if (transform.position.x > xright)
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
    }
}
