using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pet : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    public Transform Player;
    private Transform Pet;
    public float Follow_distance;
    public float speed;
    private Animator anim;
    public BoxCollider2D Bc;
    void Start()
    {
        Pet = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        Bc = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Follow();
    }

    void Follow()
    {
        Vector3 player_trans = Player.transform.position;
        Vector3 pet_trans = Pet.transform.position;
        float distance = Vector3.Distance(player_trans, pet_trans);
        float rotation_z = (distance - 3f) * 5;
        // Debug.Log(Vector3.Distance(player_trans, pet_trans));
        speed = distance / 1.2f;
        Vector3 direction = (Player.transform.position - Pet.transform.position).normalized;

        //¸úËæ¿ØÖÆ
        if (distance > Follow_distance)
        {
            rb.velocity = direction * speed;
            anim.SetBool("follow", true);
        }
        else
        {
            rb.velocity = direction * 0;
            anim.SetBool("follow", false);
        }

        //³¯Ïò¿ØÖÆ
        if (Player.transform.position.x > Pet.transform.position.x)
        {
            Pet.transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            Pet.transform.localScale = new Vector3(-1, 1, 1);
        }

        //Ðý×ª¿ØÖÆ
        if (rb.velocity.x > 0)
        {
            Pet.transform.localRotation = Quaternion.Euler(0, 0, -rotation_z);
        }
        else if (rb.velocity.x < 0)
        {
            Pet.transform.localRotation = Quaternion.Euler(0, 0, rotation_z);
        }
        else
        {
            Pet.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }

        /* //´©Ç½¿ØÖÆ
         if (distance > 5)
         {
             Bc.isTrigger = true;
         }
         else
         {
             Bc.isTrigger = false;
         }*/
    }
}