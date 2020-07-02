using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private SpriteRenderer rend;
    private interactable inter;
    public Sprite on;
    public Sprite off;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        inter = GetComponent<interactable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (inter.state)
            rend.sprite = on;
        else
            rend.sprite = off;
    }
}
