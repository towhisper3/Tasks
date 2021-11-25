using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class up_down : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    public Transform up_point;
    public Transform down_point;
    private float yUp;
    private float yDown;
    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        yUp = up_point.transform.position.y;
        yDown = down_point.transform.position.y;
        Destroy(up_point.gameObject);
        Destroy(down_point.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > yUp)
        {
            rb.velocity = new Vector2(transform.position.x, -speed);
        }else if (transform.position.y < yDown)
        {
            rb.velocity = new Vector2(transform.position.y, speed);
        }
    }
}
