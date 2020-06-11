using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit : MonoBehaviour
{
    interactable inter;
    // Start is called before the first frame update
    void Start()
    {
        inter = GetComponent<interactable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (inter.GetSetState)
        {
            Application.Quit();
        }
    }
}
