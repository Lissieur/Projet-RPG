using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactable : MonoBehaviour
{
    public bool state;
    public float range = 0.5f;
    private Transform target;
    private Transform player;
    private KeyCode Interact;
    private Controller controls;
    private bool inter = false;
    public moves movement;


    private void Awake()
    {
        controls = new Controller();
        controls.gameplay.interact.performed += ctx => inter = true;
        controls.gameplay.interact.canceled += ctx => inter = false;
    }


    void Start()
    {
        state = false;
        player = GameObject.Find("player").transform;
        target = GetComponent<Transform>();
        Interact = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("interact", "E"));
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        target = GetComponent<Transform>();
        UnityEditor.Handles.DrawWireDisc(target.position, Vector3.back, range);
    }



    private void FixedUpdate()
    {
        bool done = false;
        float diffx = player.position.x - target.position.x;
        float diffy = player.position.y - target.position.y;

        if (Input.GetKey(Interact))
            inter = true;
        else
        {
            inter = false;
        }

        if (diffx > 0.1f && diffx < range && movement.dir == "left" && inter)
        {
            done = true;
            state = true;
        }


        if (diffx < -0.1f && diffx > -range && movement.dir == "right" && inter)
        {
            done = true;
            state = true;
        }



        if (diffy > 0.1f && diffy < range && movement.dir == "down" && inter)
        {
            done = true;
            state = true;
        }


        if (diffy < -0.1f && diffy > -range && movement.dir == "up" && inter)
        {
            done = true;
            state = true;
        }


        if (!done)
            state = false;
    }
}
