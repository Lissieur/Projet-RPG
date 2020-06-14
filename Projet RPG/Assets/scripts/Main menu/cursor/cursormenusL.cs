using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursormenusL : MonoBehaviour
{
    private Transform cursor;
    public Transform[] list;
    private int pos = 0;
    int l;
    // Start is called before the first frame update
    void Start()
    {
        l = list.Length;
        cursor = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //on se balade entre les boutons du menu
        if (Input.GetKeyDown(KeyCode.S))
            pos++;

        if (Input.GetKeyDown(KeyCode.Z))
            pos--;
        //--------------------------------------

        //on gère les corners cases
        if (pos >= l)
            pos = 0;

        if (pos < 0)
            pos = l - 1;
        //-------------------------
        //on déplace le curseur
        SpriteRenderer rend = list[pos].GetComponent<SpriteRenderer>();
        float ext = rend.sprite.bounds.extents.x;
        float newposx = list[pos].position.x - ext *3f;//ext * 6f;

        cursor.SetPositionAndRotation(new Vector3(newposx, list[pos].position.y, cursor.position.z), cursor.rotation);
        //---------------------
    }
    public int GetCursorPos
    {
        get => pos;
    }
}

