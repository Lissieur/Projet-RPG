using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventaire : MonoBehaviour
{

    bool activation = false;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Canvas>().enabled = activation;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            activation = !activation;
            GetComponent<Canvas>().enabled = activation;
        }
    }
}
