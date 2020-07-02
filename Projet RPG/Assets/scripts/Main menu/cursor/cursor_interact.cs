using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursor_interact : MonoBehaviour
{
    private cursormenusL cursors;
    interactable inter;
    // Start is called before the first frame update
    void Start()
    {
        cursors = GetComponent<cursormenusL>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Transform target = cursors.list[cursors.GetCursorPos];
            inter = target.GetComponent<interactable>();
            inter.state = true;
        }
    }
}
