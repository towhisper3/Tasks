using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpbox : MonoBehaviour
{
    public BoxCollider2D Bc;
    public LayerMask Ground;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        Bc = GetComponent<BoxCollider2D>();
        // rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    public void Jump()
    {
        if (Input.GetButtonDown("Jump") && rb.IsTouchingLayers(Ground))
        {
        }
    }
}
