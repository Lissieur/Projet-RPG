using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit : MonoBehaviour
{
    buttons inter;
    // Start is called before the first frame update
    void Start()
    {
        inter = GetComponent<buttons>();
    }

    // Update is called once per frame
    void Update()
    {
        if (inter.state)
        {
            Application.Quit();
        }
    }
}
