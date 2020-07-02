using UnityEngine;


public class moves : MonoBehaviour
{
    public float speed;
    private float s = 0;
    private float hormove = 0;
    private float vermove = 0;
    private float axisx = 0;
    private float axisy = 0;
    public  Rigidbody2D rb;
    public bool armed;
    private Vector3 velocité = Vector3.zero;
    private Animator anim;
    public string dir = "down";

    private bool sprinting = false;

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

    private Controller controls;

    public float boxx = 0;
    public float boxy = -1;
    private float decal = 0.8f;

    private void Awake()
    {
        s = speed;
        controls = new Controller();

        controls.gameplay.sprint.performed += ctx => sprinting = true;
        controls.gameplay.sprint.canceled += ctx => sprinting = false;

        controls.gameplay.dodge.performed += ctx => dodging = true;
        controls.gameplay.dodge.canceled += ctx => dodging = false;

        controls.gameplay.move.performed += ctx => axisx = ctx.ReadValue<Vector2>().x ;
        controls.gameplay.move.performed += ctx => axisy = ctx.ReadValue<Vector2>().y ;
        controls.gameplay.move.canceled += ctx => cancelmove();


        
    }

    void Start()
    {
        anim = GetComponent<Animator>();
        up = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("up", ""));
        left = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("left", ""));
        down = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("down", ""));
        right = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("right", ""));
        sprint = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("sprint", ""));
        dodge = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("dodge", ""));
    }

    void FixedUpdate()
    {


        s = speed;

        #region get controller input

        if (sprinting)
            speed *= 1.8f;

        if (axisx>0)
        {
            hormove = speed * Time.deltaTime;
            anim.SetBool("right", true);
            anim.SetBool("down", false);
            anim.SetBool("up", false);
            anim.SetBool("left", false);

            dir = "right";

            boxx = decal;
            boxy = 0;

            if (time == 0)
                hordodge = hormove;
        }

        if (axisx<0)
        {
            hormove = -1 * speed * Time.deltaTime;
            anim.SetBool("left", true);
            anim.SetBool("down", false);
            anim.SetBool("up", false);
            anim.SetBool("right", false);

            dir = "left";

            boxx = -decal;
            boxy = 0;

            if (time == 0)
                hordodge = hormove;
        }

        if (axisy>0)
        {
            vermove = speed * Time.deltaTime;
            anim.SetBool("up", true);
            anim.SetBool("left", false);
            anim.SetBool("right", false);
            anim.SetBool("down", false);

            dir = "up";

            boxy = 0.4f;
            boxx = 0;

            if (time == 0)
                verdodge = vermove;
        }

        if (axisy<0)
        {
            vermove = -1 * speed * Time.deltaTime;
            anim.SetBool("down", true);
            anim.SetBool("left", false);
            anim.SetBool("right", false);
            anim.SetBool("up", false);

            dir = "down";

            boxy = -decal;
            boxx = 0;

            if (time == 0)
                verdodge = vermove;
        }

        #endregion

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

            boxx = decal;
            boxy = 0;

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

            boxx = -decal;
            boxy = 0;

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

            boxy = 0.4f;
            boxx = 0;

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

            boxy = -decal;
            boxx = 0;

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

        #region dodge or movement ?
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
        #endregion

        speed = s;
        hormove = 0;
        vermove = 0;
    }
    void moveplayer(float _hormove, float _vermove)
    {
        Vector3 target_velocity = new Vector2(_hormove, _vermove);
        rb.velocity = Vector3.SmoothDamp(rb.velocity, target_velocity,ref velocité, 0.05f);
    }

    void Sprint()
    {
        speed *= 1.8f;
    }
    void cancelmove (){
        axisx = 0;
        axisy = 0;
    }

    private void OnEnable()
    {
        controls.gameplay.Enable();
    }
    private void OnDisable()
    {
        controls.gameplay.Disable();
    }
}
