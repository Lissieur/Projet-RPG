using UnityEngine;
using System.Threading;


public class moves : MonoBehaviour
{
    public float speed;
    public  Rigidbody2D rb;
    public bool armed;
    private Vector3 velocité = Vector3.zero;
    private Animator anim;
    public string dir;
    private float time = 0;
    private bool dodging = false;
    private float hordodge;
    private float verdodge;

    private KeyCode up;
    private KeyCode left;
    private KeyCode down;
    private KeyCode right;
    private KeyCode sprint;
    private KeyCode dodge;
    void Start()
    {
        anim = GetComponent<Animator>();
        dir = "down";
        up = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("up", ""));
        left = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("left", ""));
        down = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("down", ""));
        right = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("right", ""));
        sprint = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("sprint", ""));
        dodge = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("dodge", ""));
    }
        void FixedUpdate()
    {
        float hormove = 0;
        float vermove = 0;
        float s = speed;

        #region get inputs keyboard
        if (Input.GetKey(sprint))
                speed *= 1.8f;
        if (Input.GetKey(right))
        {
            hormove = speed * Time.deltaTime;
            anim.SetBool("right", true);
            anim.SetBool("down", false);
            anim.SetBool("up", false);
            anim.SetBool("left", false);
            dir = "right";
            if (time == 0)
                hordodge = hormove;
        }

        if (Input.GetKey(left))
        {
            hormove = -1 * speed * Time.deltaTime;
            anim.SetBool("left", true);
            anim.SetBool("down", false);
            anim.SetBool("up", false);
            anim.SetBool("right", false);
            dir = "left";
            if (time == 0)
                hordodge = hormove;
        }

        if (Input.GetKey(up))
        {
            vermove = speed * Time.deltaTime;
            anim.SetBool("up", true);
            anim.SetBool("left", false);
            anim.SetBool("right", false);
            anim.SetBool("down", false);
            dir = "up";
            if (time == 0)
                verdodge = vermove;
        }

        if (Input.GetKey(down))
        {
            vermove = -1 * speed * Time.deltaTime;
            anim.SetBool("down", true);
            anim.SetBool("left", false);
            anim.SetBool("right", false);
            anim.SetBool("up", false);
            dir = "down";
            if (time == 0)
                verdodge = vermove;
        }
        #endregion
        #region reset des anims
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
        #endregion
        

        if (Input.GetKey(dodge) && time == 0)
        {
            dodging = true;
            time = Time.realtimeSinceStartup;
        }

        if (dodging && Time.realtimeSinceStartup - time < 0.1f && armed)
        {
            moveplayer(hordodge * 4, verdodge * 4);
        }
        else
        {
            dodging = false;
            time = 0;
            hordodge = 0;
            verdodge = 0;
            moveplayer(hormove, vermove);
        }
        
        speed = s;
    }
    void moveplayer(float _hormove, float _vermove)
    {
        Vector3 target_velocity = new Vector2(_hormove, _vermove);
        rb.velocity = Vector3.SmoothDamp(rb.velocity, target_velocity,ref velocité, 0.05f);
    }
}
