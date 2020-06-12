using UnityEngine;

public class moves : MonoBehaviour
{
    public float speed;
    public  Rigidbody2D rb;
    private Vector3 velocité = Vector3.zero;
    private Animator anim;
    public string dir;
    void Start()
    {
        anim = GetComponent<Animator>();
        dir = "down";
    }

    void FixedUpdate()
    {
        float hormove = 0;
        float vermove = 0;
        float s = speed;
        
        if (Input.GetKey(KeyCode.LeftShift))
            speed *= 1.8f;
        if (Input.GetKey(KeyCode.D))
        {
            hormove = speed * Time.deltaTime;
            anim.SetBool("right", true);
            anim.SetBool("down", false);
            anim.SetBool("up", false);
            anim.SetBool("left", false);
            dir = "right";
        }

        if (Input.GetKey(KeyCode.Q))
        {
            hormove = -1 * speed * Time.deltaTime;
            anim.SetBool("left", true);
            anim.SetBool("down", false);
            anim.SetBool("up", false);
            anim.SetBool("right", false);
            dir = "left";
        }

        if (Input.GetKey(KeyCode.Z))
        {
            vermove = speed * Time.deltaTime;
            anim.SetBool("up", true);
            anim.SetBool("left", false);
            anim.SetBool("right", false);
            anim.SetBool("down", false);
            dir = "up";
        }

        if (Input.GetKey(KeyCode.S))
        {
            vermove = -1 * speed * Time.deltaTime;
            anim.SetBool("down", true);
            anim.SetBool("left", false);
            anim.SetBool("right", false);
            anim.SetBool("up", false);
            dir = "down";
        }
        if (hormove == 0)
        {
            anim.SetBool("left", false);
            anim.SetBool("right", false);
            
        }
        if (vermove == 0)
        {
            anim.SetBool("down", false);
            anim.SetBool("up", false);
        }

        moveplayer(hormove, vermove);
        speed = s;
    }
    void moveplayer(float _hormove, float _vermove)
    {
        Vector3 target_velocity = new Vector2(_hormove, _vermove);
        rb.velocity = Vector3.SmoothDamp(rb.velocity, target_velocity,ref velocité, 0.05f);
    }
}
