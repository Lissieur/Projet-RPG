using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorsmenus : MonoBehaviour
{
    private Transform cursor;
    public Transform button1;
    public Transform button2;
    public Transform button3;
    private Transform[] list;
    int pos = 0;
    int l;
    // Start is called before the first frame update
    void Start()
    {
        list = new Transform[] { button1, button2, button3};
        l = list.Length;
        cursor = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            pos++;
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            pos--;
        }
        if (pos > l)
        {
            pos = l-1;
        }
        while (list[pos] == null)
        {
            pos--;
        }
        cursor.SetPositionAndRotation(new Vector3(cursor.position.x, list[pos].position.y, cursor.position.z), cursor.rotation);
    }
}
