using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactable : MonoBehaviour
{
    private bool state;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public bool GetSetState
    {
        set => state = value;
        get => state;
    }
}
