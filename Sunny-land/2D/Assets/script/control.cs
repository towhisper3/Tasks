using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class control : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;//碰撞体
    public float speed;
    public float jumpforce;
    public Animator anim;//动画
    public CircleCollider2D Cc;//刚体
    public BoxCollider2D Bc;
    public LayerMask Ground;
    private bool ishurt;
    public health health;//health脚本
    public Transform toppoint;
    public GameObject bullet;
    public GameObject collected;//被收集的动画
    private Rigidbody2D bullet_rb;
    public AudioSource fireAudio;
    public AudioSource jumpAudio;
    public AudioSource hurtAudio;
    public AudioSource eat;
    public Animator fruit_anim;
    

    // Update is called once per frame

    void Update()
    {
        if (!ishurt)
        {
            Movement();
        }
        SwitchAnimation();
        Dead();
    }
    void Movement()
    {
        float horizontalmove = Input.GetAxis("Horizontal");
        float facedirection = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(horizontalmove * speed , rb.velocity.y);
        anim.SetFloat("running", Mathf.Abs(facedirection));


        if (facedirection != 0)
        {
            transform.localScale = new Vector3(facedirection, 1, 1);
        }

        Jump();
        crouch();
        Fire();
        addHealth();
    }
    void SwitchAnimation()
    {
        anim.SetBool("idel", true);

        if (rb.velocity.y < 0)
        {
            anim.SetBool("falling", true);
        }

        if (anim.GetBool("jumping"))
        {
            if (rb.velocity.y < 0)
            {
                anim.SetBool("falling", true);
                anim.SetBool("jumping", false);
            }
        }
        else if (anim.GetBool("falling") && rb.IsTouchingLayers(Ground))
        {
            anim.SetBool("falling", false);
            anim.SetBool("idel", true);
        }
        else if (Mathf.Abs(rb.velocity.x) < 1)
        {
            ishurt = false;
            anim.SetBool("hurt", false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)//收集
    {
      
        if (collision.tag == "cherry")
        {
            Destroy(collision.gameObject);
            GameObject collect = GameObject.Instantiate(collected, collision.transform.position, collision.transform.rotation);
            eat.Play();//音效
            health.cherryNum++;
        }
        else if(collision.tag == "gem")
        {
            Destroy(collision.gameObject);
            GameObject collect = GameObject.Instantiate(collected, collision.transform.position, collision.transform.rotation);
            eat.Play();//音效
            health.gemNum++;
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemies")
        {
            Enemy enemy = collision.gameObject.GetComponent<Enemy>();
            if (anim.GetBool("falling"))
            {
                enemy.Death();
                rb.velocity = new Vector2(rb.velocity.x, jumpforce * 0.7f);
                anim.SetBool("jumping", true);//小跳
            } else if (transform.position.x < collision.transform.position.x)
            {
                health.Hurt();
                rb.velocity = new Vector2(-5, rb.velocity.y);
                hurtAudio.Play();
                ishurt = true;
                anim.SetBool("hurt", true);
            }
            else if (transform.position.x > collision.transform.position.x)
            {
                health.Hurt();
                rb.velocity = new Vector2(5, rb.velocity.y);
                hurtAudio.Play();
                ishurt = true;
                anim.SetBool("hurt", true);
            }
        }
        if (collision.gameObject.tag == "deadline")
        {
            Invoke("reset",1f);
        }
       
    }
      void crouch()
    {
       if (!Physics2D.OverlapCircle(toppoint.position,0.2f,Ground))
        {
            if (Input.GetButton("Crouch"))
            {
                anim.SetBool("IScrouch", true);
                Bc.enabled = false;
            }
            else
            {
                anim.SetBool("IScrouch", false);
                Bc.enabled = true;
            }
        }
    }
    void Jump()
    {
        Vector3 begin = transform.position;
        Vector3 direction = new Vector3(0, -1, 0);
        if(Physics2D.Raycast(begin, direction, 1.0f, Ground))
        {
            if (Input.GetButtonDown("Jump") && rb.IsTouchingLayers(Ground) && anim.GetBool("IScrouch") == false)//趴下不能跳
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpforce);
                jumpAudio.Play();
                anim.SetBool("jumping", true);
            }
        }
    }

    void Fire()
    {
        if (Input.GetButtonDown("Fire1")&&Time.timeScale==1)
        {
            float face = transform.localScale.x;
            Vector3 start = transform.position + new Vector3(1f*face, -0.3f, 0);
             GameObject bul =GameObject.Instantiate(bullet,start,transform.rotation);
            fireAudio.Play();
            bullet_rb = bul.GetComponent<Rigidbody2D>();
            bullet_rb.AddForce(Vector2.right * 1000*face);
            //rb.transform.rotation = Quaternion.Euler(0, 0, 90f);
            bullet_rb.transform.rotation = Quaternion.Euler(0, 0, 90f*face);
        }
    }
    void addHealth()
    {
        if (Input.GetButtonDown("addHealth"))
        {
            health.Addhealth();
        }
    }

    public void Dead()//角色死亡
    {
        if (health.healthNum == 0)
        {
            Cc.enabled = false;
            Bc.enabled = false;
            Invoke("reset", 1f);
        }
        
    }
    public void reset()//重新开始
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
