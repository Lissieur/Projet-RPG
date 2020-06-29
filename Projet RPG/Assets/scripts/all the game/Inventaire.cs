using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventaire : MonoBehaviour
{
    public Canvas canvas;
    bool activation = false;
    // Start is called before the first frame update
    void Start()
    {
        canvas.enabled = activation;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            activation = !activation;
            canvas.enabled = activation;
        }
    }
}
